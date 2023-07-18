using DataLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Todo_Context
{
    public class TodoContextLayer : DbContext
    {
        public DbSet<Todo> Todo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DECAGON\\SQLEXPRESS;Database = myTodoEfCore2;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().ToTable("Todo");
        }

    }
}