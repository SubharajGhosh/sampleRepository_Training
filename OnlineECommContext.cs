using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceApp.Entities
{
    public class OnlineECommContext: DbContext
    {
        public OnlineECommContext(): base("OnlineEcommDBConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}