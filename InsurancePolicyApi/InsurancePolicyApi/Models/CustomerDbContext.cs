using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CarInsurance;

namespace CarInsurance.Models
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext() : base("AutoPolicyDbContext")
        {
            Database.SetInitializer<CustomerDBContext>(null);
        }
        public System.Data.Entity.DbSet<CarInsurance.Models.Customer> Customers { get; set; }
    }
}