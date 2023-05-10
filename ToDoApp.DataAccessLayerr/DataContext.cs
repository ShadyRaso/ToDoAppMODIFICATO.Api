using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccessLayer.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToDoApp.DataAccessLayer;

public partial class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Profile> Profiles { get; set; }
    public virtual DbSet<EventType> EventTypes { get; set; }
    public virtual DbSet<Event> Events { get; set; }
    public virtual DbSet<Users> Users { get; set; }
    public virtual DbSet<Player> Player { get; set; }


}
