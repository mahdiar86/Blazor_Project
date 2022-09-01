using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blazor_Project.Application.DTOs;
using Blazor_Project.Data.Models;

namespace Blazor_Project.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewsCategory, CategoryDTO>();
            CreateMap<CategoryDTO, NewsCategory>();

            CreateMap<NewsCategory, EditCategoryDTO>();
            CreateMap<EditCategoryDTO, NewsCategory>();

            CreateMap<News, NewsDTO>();
            CreateMap<NewsDTO, News>();

            CreateMap<News, EditNewsDTO>();
            CreateMap<EditNewsDTO, News>();
        }
    }
}
