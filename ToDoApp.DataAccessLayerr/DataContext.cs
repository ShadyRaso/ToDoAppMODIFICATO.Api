using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccessLayer.Entities;

namespace ToDoApp.DataAccessLayer;

public partial class DataContext : DbContext
{
    public virtual DbSet<Profile> Profiles { get; set; }
    public virtual DbSet<EventType> EventTypes { get; set; }
    public virtual DbSet<Event> Events { get; set; }

    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }
    
}
