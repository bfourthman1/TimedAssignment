using Microsoft.AspNetCore.Mvc;
using SocialCircle.Data;
using SocialCircleAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SocialCircleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SCControllers : Controller
    {
        private SocialCircleDbContext _context;
        public SCControllers (SocialCircleDbContext context)
        {
            _context = context;
        }

        [HttpPost]
         public async Task<IActionResult> CreatePost([FromForm] Post model)
         {
             if (!ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }

             _context.Posts.Add(new Post()
             {
                 Title = model.Title,
                 Text = model.Text,
             });

            await _context.SaveChangesAsync();
            return Ok();
         }

        [HttpGet]
         public async Task<IActionResult> GetPosts()
         {
             var Post = await _context.Posts.ToListAsync();
             return Ok(Post);
         }

        [HttpPost]
         public async Task<IActionResult> CreateComment([FromForm] Comment model)
         {
             if (!ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }

             _context.Comments.Add(new Comment ()
             {
                 Text = model.Text
             });

             await _context.SaveChangesAsync();
             return Ok();
         }
    }
}