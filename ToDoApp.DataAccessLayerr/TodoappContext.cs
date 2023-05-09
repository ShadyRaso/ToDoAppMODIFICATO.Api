using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccessLayer.Entities;

namespace ToDoApp.DataAccessLayer;

public partial class TodoappContext : DbContext
{
    public virtual DbSet<Profile> Profiles { get; set; }

    public TodoappContext()
    {
    }

    public TodoappContext(DbContextOptions<TodoappContext> options)
        : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
