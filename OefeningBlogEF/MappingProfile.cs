using AutoMapper;

namespace OefeningBlogEF
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.Category, Models.Category>();
            CreateMap<Models.PostCategory, Entities.Category>();
        }
    }
}