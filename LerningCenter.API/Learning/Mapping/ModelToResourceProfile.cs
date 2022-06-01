using AutoMapper;
using LerningCenter.API.Learning.Domain.Models;
using LerningCenter.API.Learning.Domain.Services.Communication;

namespace LerningCenter.API.Learning.Mapping;

public class ModelToResourceProfile: Profile {
    public ModelToResourceProfile() {
        CreateMap<Category, CategoryResponse>();
    }
}