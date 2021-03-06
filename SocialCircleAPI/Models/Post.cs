using System;
using System.Collections.Generic;

namespace SocialCircleAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;
        public Guid? AuthorId { get; set; }
    }
}
