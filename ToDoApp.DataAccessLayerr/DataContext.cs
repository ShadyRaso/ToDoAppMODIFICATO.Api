using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccessLayer.Entities;

namespace ToDoApp.DataAccessLayer;

public partial class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

}
