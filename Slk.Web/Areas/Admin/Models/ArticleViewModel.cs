using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slk.Web.Areas.Admin.Models
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public string UserName { get; set; }
        public DateTime CreationDate { get; set; }
    }
}