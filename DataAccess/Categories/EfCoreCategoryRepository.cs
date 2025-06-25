using DataAccess.EntityFrameworkCore;
using Domain;

namespace DataAccess.Categories;

public class EfCoreCategoryRepository(FavmyDbContext context) : BaseRepository<Category>(context), ICategoryRepository;