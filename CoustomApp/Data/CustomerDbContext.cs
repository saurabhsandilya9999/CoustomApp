using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoustomApp.Models;
using Microsoft.Extensions.Configuration;

namespace CoustomApp.Data
{
    public class CustomerDbContext : DbContext
    {
        private string connectionString;
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

