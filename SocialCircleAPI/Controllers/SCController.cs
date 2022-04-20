using Microsoft.AspNetCore.Mvc;
using SocialCircleAPI;
using SocialCircleAPI.Models;
using Microsoft.EntityFrameworkCore;
using SocialCircle.Models;

namespace SocialCircleAPI.Controllers
{
    [Route("controller")]
    [ApiController]
    public class SCController : Controller
    {
        private SocialCircleDbContext _db;
        public SCController(SocialCircleDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public async Task<IActionResult> PostPost([FromForm] PostEdit model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _db.Post.Add(new Post()
            {
                Title = model.Title,
                Text = model.Text
            });
            await _db.SaveChangesAsync();
            return Ok();
        }
    }

}