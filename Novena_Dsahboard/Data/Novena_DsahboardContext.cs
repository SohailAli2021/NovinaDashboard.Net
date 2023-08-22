using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Novena_Dsahboard.Models;

    public class Novena_DsahboardContext : IdentityDbContext
    {
        public Novena_DsahboardContext (DbContextOptions<Novena_DsahboardContext> options)
            : base(options)
        {
        }

       

        public DbSet<Novena_Dsahboard.Models.Contact> Contact { get; set; }

        public DbSet<Novena_Dsahboard.Models.Feedback> Feedback { get; set; }

        public DbSet<Novena_Dsahboard.Models.WebService> WebService { get; set; }

    public DbSet<Novena_Dsahboard.Models.Casestudy> Casestudy { get; set; }

    public DbSet<Novena_Dsahboard.Models.Appointment> Appointment { get; set; }

    public DbSet<Novena_Dsahboard.Models.Event> Event { get; set; }

    public DbSet<Novena_Dsahboard.Models.Speaker> Speaker { get; set; }

    public DbSet<Novena_Dsahboard.Models.Scientific> Scientific { get; set; }

    public DbSet<Novena_Dsahboard.Models.Product> Product { get; set; }

    public DbSet<Novena_Dsahboard.Models.Department> Department { get; set; }

    public DbSet<Novena_Dsahboard.Models.Doctor> Doctor { get; set; }
    public DbSet<Novena_Dsahboard.Models.Invoice> Invoice { get; set; }
    public DbSet<Novena_Dsahboard.Models.Order> Order { get; set; }
    public DbSet<Novena_Dsahboard.Models.Cart> Cart { get; set; }
    public DbSet<Novena_Dsahboard.Models.Checkout> Checkout { get; set; }


















}
