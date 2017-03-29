using Amazon.S3;
using Amazon.S3.Model;
using ImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
//using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Slk.Common
{
    public class AwsBucket
    {
        //private static CloudBlobContainer container;
        private static string _hostName = "https://s3-us-west-2.amazonaws.com";
        private static string _bucketName = "bucket4slk";
        private static string accessKey = "XXX";
        private static string secretKey = "YYY";

        static AwsBucket()
        {
        }

        public static string StoreImage(byte[] imageBytes, string fileName)
        {
            var newFileName = getUniqueName(fileName);

            using (var stream = new MemoryStream(imageBytes)) //System.Convert.FromBase64String(image64String)
            {
                using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey, Amazon.RegionEndpoint.USWest2))
                {
                    var request = new PutObjectRequest();
                    request.BucketName = _bucketName;
                    request.CannedACL = S3CannedACL.PublicRead;
                    request.Key = newFileName;
                    request.InputStream = stream;

                    var resp = client.PutObject(request);

                    if (resp.HttpStatusCode == System.Net.HttpStatusCode.OK)
                        return getFullName(newFileName);

                    return null;
                }
            }
        }

        public static string StoreImage(HttpPostedFileBase image)
        {
            // Read a file and resize it.
            //byte[] photoBytes = File.ReadAllBytes(file);
            int quality = 70;
            var format = new ImageProcessor.Imaging.Formats.JpegFormat();
            Size size = new Size(300, 0);

            using (var imageStream = new MemoryStream())
            {
                image.InputStream.CopyTo(imageStream);
                imageStream.Position = 0;

                using (var resizeImageStream = new MemoryStream())
                {
                    using (ImageFactory imageFactory = new ImageFactory())
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(imageStream)
                                    .Resize(size)
                                    .Format(format)
                                    .Quality(quality)
                                    .Save(resizeImageStream);
                    }

                    using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey, Amazon.RegionEndpoint.USWest2))
                    {
                        var newFileName = getUniqueName(image.FileName);

                        var request = new PutObjectRequest();
                        request.BucketName = _bucketName;
                        request.CannedACL = S3CannedACL.PublicRead;

                        // Save Resize version to folder "thumb"
                        request.Key = $"thumb/{newFileName}";
                        request.InputStream = resizeImageStream;
                        var resp = client.PutObject(request);

                        // Save Original version to root folder
                        request.Key = newFileName;
                        request.InputStream = imageStream;
                        client.PutObject(request);

                        if (resp.HttpStatusCode == System.Net.HttpStatusCode.OK)
                            return getFullName(newFileName);

                        return null;
                    }
                }
            }
        }

        public static void RemoveImage(string fileName)
        {
            using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey, Amazon.RegionEndpoint.USWest2))
            {
                client.DeleteObject(_bucketName, fileName);
                try
                {
                    client.DeleteObject($"thumb/{_bucketName}", fileName);
                }
                catch { }
                
            }
        }

        private static string getUniqueName(string fileName)
        {
            var ext = Path.GetExtension(fileName).ToLower();
            var guid = Guid.NewGuid().ToString();

            return string.Format("{0}{1}", guid, ext).ToLowerInvariant();
        }

        public static string getFullName(string fileName)
        {
            return $"{_hostName}/{_bucketName}/{fileName}";
        }

        public static IEnumerable<string> GetImages()
        {
            var lbFiles = new List<string>();

            using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey, Amazon.RegionEndpoint.USWest2))
            {
                var list = client.ListObjects(new ListObjectsRequest { BucketName = _bucketName });

                foreach (var file in list.S3Objects.Where(w => !w.Key.Contains("thumb")))
                    lbFiles.Add(getFullName(file.Key));

                return lbFiles;
            }
        }
    }
}
