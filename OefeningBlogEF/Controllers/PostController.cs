using Microsoft.AspNetCore.Mvc;
using OefeningBlogEF.Models;
using OefeningBlogEF.Services;
using System.Linq;

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
            var categories = _postRepository.GetCategories().ToList();

            if (categories.Count == 0)
                return NotFound();

            return Ok(categories);
        }

        [HttpPost]
        [Route("AddCategory")]
        public IActionResult AddCategory(PostCategory model)
        {
            var newCategory = _postRepository.AddCategory(model);

            return CreatedAtAction(
               nameof(AddCategory),
               new { id = newCategory.Id},
               newCategory);
        }

        [HttpGet]
        [Route("GetPosts")]
        public IActionResult GetPosts(int categoryId)
        {
            var posts = _postRepository.GetPostsByCategoryId(categoryId).ToList();

            if (posts.Count == 0)
                return NotFound();

            return Ok(posts);
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
