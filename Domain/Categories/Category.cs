using Core.Entities;

namespace Domain;

public class Category : BaseEntity
{
    public string Name { get; private set; }
    public ICollection<Product> Products { get; set; }

    protected Category()
    {
        
    }
    public Category(string name)
    {
        SetName(name);
    }

    private void SetName(string name)
    {
        Name = name;
    }
}
