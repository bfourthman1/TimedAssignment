using Microsoft.AspNetCore.Mvc;
using SocialCircle.Data;
using SocialCircleAPI.Models;
using Microsoft.EntityFrameworkCore;
using SocialCircleAPI.models;

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

         [HttpGet]
         [Route("{PostId}")]
         public async Task<IActionResult> GetCommentsByPostId(int PostId)
         {
             var Comment = await _context.Comments.FindAsync(PostId);
             if (PostId == null){
                 return NotFound();
             }
             return Ok(Comment);
         }

         [HttpPost]
         public async Task<IActionResult> CreateReply([FromForm] Reply model)
         {
             if (!ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }

             _context.Replies.Add(new Reply ()
             {
                 Text = model.Text
             });

             await _context.SaveChangesAsync();
             return Ok();
         }

         [HttpGet]
         [Route("{PostId}")]
         public async Task<IActionResult> GetRepliesByPostId(int PostId)
         {
             var Reply = await _context.Comments.FindAsync(PostId);
             if (PostId == null){
                 return NotFound();
             }
             return Ok(Reply);
         }

         [HttpGet]
         public async Task<IActionResult> GetLikesByPostId( int PostId)
         {
             var Like = await _context.Likes.FindAsync(PostId);
             if (PostId == null){
                 return NotFound();
             }
             return Ok(Like);
         }

        [HttpPost]
         public async Task<IActionResult> CreateLike([FromForm] Like model)
        {
             if (!ModelState.IsValid)
            {
                 return BadRequest(ModelState);
            }
            _context.Likes.Add(new Like()
            {
                Id = model.Id
            });

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}