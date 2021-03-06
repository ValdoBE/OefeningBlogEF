﻿using AutoMapper;
using OefeningBlogEF.Entities;
using OefeningBlogEF.Models;
using System.Collections.Generic;
using System.Linq;

namespace OefeningBlogEF.Services
{
    public interface IPostRepository
    {
        IEnumerable<Models.Category> GetCategories();
        Models.Category AddCategory(PostCategory model);

        IEnumerable<Models.Post> GetPostsByCategoryId(int categoryId);
        //Models.Post AddPost(PostForCreate )
    }

    public class PostRepository : IPostRepository
    {
        private readonly IMapper _mapper;
        private readonly BlogContext _blogContext;

        public PostRepository(BlogContext blogContext, IMapper mapper)
        {
            _mapper = mapper;
            _blogContext = blogContext;
        }

        public IEnumerable<Models.Category> GetCategories()
        {
            return _blogContext.Categories.Select(c => _mapper.Map<Models.Category>(c));
        }

        public Models.Category AddCategory(PostCategory model)
        {
            var newCategory = _mapper.Map<Entities.Category>(model);

            _blogContext.Categories.Add(newCategory);
            _blogContext.SaveChanges();

            return _mapper.Map<Models.Category>(newCategory);
        }

        public IEnumerable<Models.Post> GetPostsByCategoryId(int categoryId)
        {
            return _blogContext.Posts.Where(p => p.CategoryId == categoryId).Select(p => _mapper.Map<Models.Post>(p));
        }
    }
}
