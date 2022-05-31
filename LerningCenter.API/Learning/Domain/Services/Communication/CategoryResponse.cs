using LerningCenter.API.Learning.Domain.Models;
using LerningCenter.API.Shared.Domain.Services.Communication;

namespace LerningCenter.API.Learning.Domain.Services.Communication;

public class CategoryResponse: BaseResponse<Category> {
    public CategoryResponse(Category resource) : base(resource) {
        
    }
    public CategoryResponse(string message) : base(message) {
        
    }
}