using Microsoft.AspNetCore.Mvc;
using SocialCircle.Data;

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
        // [HttpPost]
        // public async Task<IActionResult> PostComment()
        // {
        // }
    }
}