namespace Slk.Models
{
    public class PostRequestArticle
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
    }
}
