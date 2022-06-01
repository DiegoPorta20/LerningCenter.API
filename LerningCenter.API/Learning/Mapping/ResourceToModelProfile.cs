using AutoMapper;
using LerningCenter.API.Learning.Domain.Models;
using LerningCenter.API.Learning.Resources;

namespace LerningCenter.API.Learning.Mapping;

public class ResourceToModelProfile: Profile {
    public ResourceToModelProfile() {
        CreateMap<SaveCategoryResource, Category>();
    }
}