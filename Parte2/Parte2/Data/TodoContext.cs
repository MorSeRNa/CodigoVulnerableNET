using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Parte2.Models;

namespace Parte2.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
