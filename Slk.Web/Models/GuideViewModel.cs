using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Slk.Models;

namespace Slk.Web.Models
{
    public class GuideViewModel
    {
        public GuideViewModel()
        {
            Categories = new List<Category>();
            Articles = new List<Article>();
        }

        public IEnumerable<Category> Categories { get; set; }
        public int ActiveCategoryId { get; set; }
        public IEnumerable<Article> Articles { get; set; }
    }
}