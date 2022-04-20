using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialCircleAPI.models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        public Guid OwnerId { get; set; }

        [Required]
        [ForeignKey("Post")]
    }
}