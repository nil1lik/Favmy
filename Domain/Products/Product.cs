using Core.Entities;
namespace Domain;

public class Product : BaseEntity
{
    public string Name { get; private set; }
    public string Url { get; private set; }
    public DateTime CreatedTime { get; private set; }
    public bool Urgency { get; private set; } //Aciliyet durumu
    public Guid CategoryId { get; private set; }
    public Category Category { get; set; }

    protected Product()
    {
        
    }
    public Product(string name, string url, DateTime createdTime, bool urgency, Guid categoryId)
    {
        SetName(name);
        SetUrl(url);
        SetCreatedTime(createdTime);
        SetUrgency(urgency);
        SetCategoryId(categoryId);
    }

    private void SetName(string name)
    {
        Name = name;
    }

    private void SetUrl(string url)
    {
        Url = url;
    }

    private void SetCreatedTime(DateTime createdTime)
    {
        CreatedTime = createdTime;
    }

    private void SetUrgency(bool urgency)
    {
        Urgency = urgency;
    }

    private void SetCategoryId(Guid categoryId)
    {
        CategoryId = categoryId;
    }
}
