using System;
using System.Collections.Generic;
using System.Linq;

namespace Slk.Web.Models
{
    public class PhotosViewModel
    {
        public PhotosViewModel()
        {
            Photos = new List<string>();
        }

        public IEnumerable<string> Photos { get; set; }
    }
}