using System.Runtime.CompilerServices;
using AutoMapper;
using Blazor_Project.Application.DTOs;
using Blazor_Project.Application.Interfaces;
using Blazor_Project.Data.Models;
using Blazor_Project.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Project.Application.Services;

public class NewsService : INewsService
{
    #region Constructor

    private readonly IGenericRepository<NewsCategory> _newsCategoryRepository;
    private readonly IGenericRepository<News> _newsRepository;
    private readonly IMapper _mapper;

    public NewsService(IGenericRepository<NewsCategory> newsCategoryRepository, IMapper mapper, IGenericRepository<News> newsRepository)
    {
        _newsCategoryRepository = newsCategoryRepository;
        _mapper = mapper;
        _newsRepository = newsRepository;
    }

    #endregion

    #region Dispose

    public async ValueTask DisposeAsync()
    {
        await _newsCategoryRepository.DisposeAsync();
    }

    #endregion

    #region Get Categories

    public async Task<List<NewsCategory>> GetNewsCategories()
    {
        return await _newsCategoryRepository.GetQuery().ToListAsync();
    }

    #endregion

    #region Add Category

    public async Task AddCategory(CategoryDTO category)
    {
        NewsCategory newsCategory = _mapper.Map<CategoryDTO, NewsCategory>(category);
        await _newsCategoryRepository.AddEntity(newsCategory);
        await _newsCategoryRepository.SaveChanges();
    }

    #endregion

    #region Edit Category

    public async Task EditCategory(EditCategoryDTO category)
    {

        var newsCategory = await _newsCategoryRepository.GetEntityById(category.Id);
        newsCategory.Title = category.Title;

        _newsCategoryRepository.EditEntity(newsCategory);
        await _newsCategoryRepository.SaveChanges();
    }

    #endregion

    #region Delete Category

    public async Task DeleteCategory(int categoryId)
    {
        var category = await _newsCategoryRepository.GetEntityById(categoryId);

        if (category != null)
        {
            category.IsDelete = true;
            _newsCategoryRepository.EditEntity(category);
            await _newsCategoryRepository.SaveChanges();
        }
    }

    #endregion

    #region Get Category By Id

    public async Task<EditCategoryDTO> GetCategoryById(int id)
    {
        return _mapper.Map<NewsCategory, EditCategoryDTO>(await _newsCategoryRepository.GetEntityById(id));
    }


    #endregion

    #region Get News By Id

    public async Task<News> GetNewsById(int id)
    {
        return await _newsRepository.GetEntityById(id);
    }

    #endregion

    #region News CRUD

    public async Task AddNews(NewsDTO news)
    {
        await _newsRepository.AddEntity(_mapper.Map<NewsDTO, News>(news));
        await _newsRepository.SaveChanges();
    }

    public async Task EditNews(EditNewsDTO news)
    {
        var editNews = await _newsRepository.GetEntityById(news.Id);
        if (editNews != null)
        {
            editNews.Description = news.Description;
            editNews.ShortDescription = news.ShortDescription;
            editNews.ImageName = news.ImageName;
            editNews.Visits = news.Visits;
            editNews.NewsCategoryId = news.NewsCategoryId;
            editNews.Title = news.Title;

            _newsRepository.EditEntity(editNews);
            await _newsCategoryRepository.SaveChanges();
        }
    }

    public async Task DeleteNews(int newsId)
    {
        var news = await _newsRepository.GetEntityById(newsId);
        news.IsDelete = true;

        _newsRepository.EditEntity(news);

        await _newsCategoryRepository.SaveChanges();
    }

    public async Task<List<News>> GetLatestNewses(int count)
    {
        return await _newsRepository
            .GetQuery()
            .AsQueryable()
            .Take(count)
            .ToListAsync();
    }

    #endregion
}