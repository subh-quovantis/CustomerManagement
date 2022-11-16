using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerManagement.Models;

namespace CustomerManagement.Data
{
    public class CustomerManagementContext : DbContext
    {
        public CustomerManagementContext (DbContextOptions<CustomerManagementContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerManagement.Models.CustomerDetails> CustomerDetails { get; set; } = default!;

        public DbSet<CustomerManagement.Models.Orders> Orders { get; set; } = default!;
    }
}
