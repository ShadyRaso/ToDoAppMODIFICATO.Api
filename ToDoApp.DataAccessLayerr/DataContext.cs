using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccessLayer.Entities;

namespace ToDoApp.DataAccessLayer;

public partial class DataContext : DbContext
{
<<<<<<< HEAD
=======
    public virtual DbSet<Profile> Profiles { get; set; }
    public virtual DbSet<EventType> EventTypes { get; set; }
    public virtual DbSet<Event> Events { get; set; }

    public DataContext()
    {
    }

>>>>>>> origin/event/type
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }
<<<<<<< HEAD

    public DbSet<Users> Users => Set<Users>();

=======
    
>>>>>>> origin/event/type
}
