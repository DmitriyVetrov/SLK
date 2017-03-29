using System;

namespace Slk.Models
{
    public class Comment : AppEntity
    {
        public string Body { get; set; }
        public int UserId { get; set; }
        public int ArticleId { get; set; }
    }
}