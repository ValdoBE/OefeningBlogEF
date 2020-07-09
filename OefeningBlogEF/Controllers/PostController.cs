using Microsoft.AspNetCore.Mvc;
using OefeningBlogEF.Models;
using OefeningBlogEF.Services;

namespace OefeningBlogEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        
        [HttpGet]
        [Route("GetCategories")]
        public IActionResult GetCategories()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetPosts")]
        public IActionResult GetPosts(int categoryId)
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetPost")]
        public IActionResult GetPost(int postId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("AddPost")]
        public IActionResult AddPost(PostForCreate model)
        {
            return Ok();
        }

        [HttpPut]
        [Route("UpdatePost")]
        public IActionResult UpdatePost(PostForUpdate model)
        {
            return Ok();
        }
    }
}
