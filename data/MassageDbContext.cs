using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
namespace Data
{
#pragma warning restore format
public class MassageDbContext : DbContext
{
    public MassageDbContext(DbContextOptions<MassageDbContext> options)
        : base(options)
    {
    }
    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=MetaGolf;User=root;Password=zsl@Calgary23;",new MySqlServerVersion(new Version(8, 0, 23)));
           }
        }*/
    // Define DbSet properties for other entities
    public DbSet<FutureEvent> FutureEvents {get;set;} 
    public DbSet<MssgTherapy> MassageTherapies {get;set;}
    public DbSet<OfferedService> OfferedServices {get;set;}
    public DbSet<PrivateChef> PrivateChefs {get;set;}
    public DbSet<Section> Sections {get;set;}
    public DbSet<Customer> Customers {get;set;}
    public DbSet<CustomerFeedback> CustomerFeedbacks{get;set;}
    public DbSet<BusinessProfile> BusinessProfiles{get;set;}
    public DbSet<Gallery> Galleries {get;set;}
}

}