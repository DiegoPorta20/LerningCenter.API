namespace LerningCenter.API.Learning.Domain.Models;

public class Category {
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
} 