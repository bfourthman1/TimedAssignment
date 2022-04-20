namespace SocialCircle.Models
{
    public class Comment
    {
        public int Id {get; set;}
        public string Text {get; set;}
        public Guid AuthorId {get; set;}
        public int PostId {get; set;}
    }
}