using Microsoft.EntityFrameworkCore;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Model.Domain.Task;

namespace Model
{
    public class FonisContext: DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<ArchivedTask> ArchivedTasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FonisProjects;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>().HasOne(e => e.Team).WithMany().HasForeignKey(e => e.TaskId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>().HasOne(e => e.Position).WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Group>().OwnsMany(o => o.ArchivedTasks);
        }
    }
}
