using System;

namespace OefeningBlogEF.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
