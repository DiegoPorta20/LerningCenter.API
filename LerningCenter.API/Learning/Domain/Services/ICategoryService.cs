using LerningCenter.API.Learning.Domain.Models;
using LerningCenter.API.Learning.Domain.Services.Communication;

namespace LerningCenter.API.Learning.Domain.Services;

public interface ICategoryService
{
    Task<IEnumerable<Category>> ListAsync();
    Task<CategoryResponse> SaveSync(Category category);
    Task<CategoryResponse> UpdateSync(int id, Category category);
    Task<CategoryResponse> DeleteSync(int id);
}