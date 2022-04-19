namespace SocialCircleAPI.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(255)]
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
    }
}