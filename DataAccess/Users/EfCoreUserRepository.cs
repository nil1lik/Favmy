using DataAccess.EntityFrameworkCore;
using Domain;

namespace DataAccess.Users;

public class EfCoreUserRepository(FavmyDbContext context) : BaseRepository<User>(context), IUserRepository;