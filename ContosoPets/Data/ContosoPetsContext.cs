using ContosoPets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoPets.Data
{
    public class ContosoPetsContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet <ProductOrder> productOrders { get; set; }
    }
}
