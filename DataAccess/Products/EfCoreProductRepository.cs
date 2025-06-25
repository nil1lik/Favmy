using DataAccess.EntityFrameworkCore;
using Domain;

namespace DataAccess.Products;

public class EfCoreProductRepository(FavmyDbContext context) : BaseRepository<Product>(context), IProductRepository;