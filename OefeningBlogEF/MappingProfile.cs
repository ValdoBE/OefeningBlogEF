using AutoMapper;

namespace OefeningBlogEF
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.Category, Models.Category>();
            CreateMap<Models.PostCategory, Entities.Category>();

            CreateMap<Models.PostForCreate, Entities.Post>();

            CreateMap<Entities.Post, Models.Post>()
                .ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));
        }
    }
}