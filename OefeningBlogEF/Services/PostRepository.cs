using AutoMapper;
using OefeningBlogEF.Entities;

namespace OefeningBlogEF.Services
{
    public interface IPostRepository
    {

    }

    public class PostRepository : IPostRepository
    {
        private readonly IMapper _mapper;
        private readonly BlogContext _blogContext;

        public PostRepository(BlogContext blogContext, IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
