using Core.Entities;

namespace Domain;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }

    public Category(string name, ICollection<Product> products)
    {
        Name = name;
        Products = products;
    }
}
