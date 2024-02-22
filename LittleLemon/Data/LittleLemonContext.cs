using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LittleLemon.Models;

namespace LittleLemon.Data
{
    public class LittleLemonContext : DbContext
    {
        public LittleLemonContext (DbContextOptions<LittleLemonContext> options)
            : base(options)
        {
        }

        public DbSet<LittleLemon.Models.Customer> Customer { get; set; } = default!;
        public DbSet<LittleLemon.Models.Contact> Contact { get; set; } = default!;
        public DbSet<LittleLemon.Models.Order> Order { get; set; } = default!;
    }
}
