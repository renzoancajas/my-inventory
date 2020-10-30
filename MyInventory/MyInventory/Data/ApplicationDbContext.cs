using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace MyInventory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
