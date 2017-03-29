using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Slk.Models
{
    public class Article : AppEntity
    {
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string BackgroundImageUrl { get; set; }
        //public string BackgroundImageBin { get; set; }
        public HttpPostedFileBase UploadImage { get; set; }
    }
}
