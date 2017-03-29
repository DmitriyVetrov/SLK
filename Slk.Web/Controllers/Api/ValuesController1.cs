using Slk.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Slk.Web.Controllers.Api
{
    public class BucketController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("api/file-upload-batch/{tip}")]
        public void Post(HttpPostedFileBase file)
        {
            var r = file;
        }

        [HttpPost, Route("api/upload/{id}")]
        public async Task<IHttpActionResult> Upload(int id)
        {
            if (!Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            var urlImage = string.Empty;

            var provider = new MultipartMemoryStreamProvider();
            await Request.Content.ReadAsMultipartAsync(provider);

            foreach (var file in provider.Contents)
            {
                var filename = file.Headers.ContentDisposition.FileName.Trim('\"');
                var buffer = await file.ReadAsByteArrayAsync();

                //Do whatever you want with filename and its binaray data.
                urlImage = AwsBucket.StoreImage(buffer, filename);
            }

            var _guideService = new Services.GuideService();
            var article = _guideService.GetArticle(id);
            article.BackgroundImageUrl = urlImage;
            _guideService.PostArticle(article);

            return Json(urlImage);
        }

        [HttpPost, Route("api/remove/{id}")]
        public IHttpActionResult Remove(int id, FileRequest request)
        {
            if(string.IsNullOrEmpty(request.Key))
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var key = request.Key.Substring(request.Key.Length - 40);
            AwsBucket.RemoveImage(key);

            var _guideService = new Services.GuideService();
            var article =  _guideService.GetArticle(id);
            article.BackgroundImageUrl = null;
            _guideService.PostArticle(article);

            return Json("");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }

    public class FileRequest
    {
        public string Key { get; set; }
        public int ArticleId { get; set; }
        public HttpPostedFileBase Image { get; set; }
    }
}