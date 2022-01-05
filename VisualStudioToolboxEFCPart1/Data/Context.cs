using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualStudioToolboxEFCPart1.Models;

namespace VisualStudioToolboxEFCPart1.Data
{
    public class Context:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductionOrder> ProductionOrders { get; set; }


        // an instance of DbContextOptionsBuilder is used to specify which database to use
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder2)
        {
            //an instance of DbContextOptionsBuilder is used to specify which database to use "useSqlServer".
            optionsBuilder2.UseSqlServer(@"Data Source=DESKTOP-RKO8EC2\SQLEXPRESS02; Initial Catalog=VisualStudioToolboxEFCPart1; Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
