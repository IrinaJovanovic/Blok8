﻿using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using WebApp.Models;
using WebApp.Models.HelpModels;

namespace WebApp.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Line> Lines { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<PayPal> PayPals { get; set; }
        public DbSet<Pricelist> Pricelists { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<User> DetailedUsers { get; set; }
        public DbSet<Depature> Depatures { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

       // public System.Data.Entity.DbSet<WebApp.Models.ApplicationUser> ApplicationUsers { get; set; } //dodala Irina 27.8
    }
}