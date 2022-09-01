using Blazor_Project.Application.DTOs;
using Blazor_Project.Data.Models;

namespace Blazor_Project.Application.Interfaces;

public interface INewsService : IAsyncDisposable
{
    Task<List<NewsCategory>> GetNewsCategories();

    Task AddCategory(CategoryDTO category);

    Task EditCategory(EditCategoryDTO category);

    Task DeleteCategory(int categoryId);

    Task AddNews(NewsDTO news);

    Task EditNews(EditNewsDTO news);

    Task DeleteNews(int newsId);

    Task<List<News>> GetLatestNewses(int count);

    Task<EditCategoryDTO> GetCategoryById(int id);

    Task<News> GetNewsById(int id);
}