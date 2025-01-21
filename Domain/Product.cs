using Core.Entities;

namespace Domain;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Url { get; set; }
    public DateTime CreatedTime { get; set; }
    public string Urgency { get; set; } //Aciliyet durumu
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public Product(string name, string url, DateTime createdTime, string urgency, Guid categoryId, Category category)
    {
        Name = name;
        Url = url;
        CreatedTime = createdTime;
        Urgency = urgency;
        CategoryId = categoryId;
        Category = category;
    }
}
