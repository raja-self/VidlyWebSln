using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VidlyWeb.Models;
namespace VidlyWeb.Models
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDBContext()
          : base("DefaultConnection")
        {
        }
    }
}