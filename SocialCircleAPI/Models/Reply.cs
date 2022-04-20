namespace SocialCircleAPI.Models
{
    public class Reply
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public Guid AuthorId { get; set; }
    }
}