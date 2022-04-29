#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetshopApp.Models;

    public class PetShopAppContext : DbContext
    {
        public PetShopAppContext (DbContextOptions<PetShopAppContext> options)
            : base(options)
        {
        }

        public DbSet<PetshopApp.Models.Proprietario> Proprietario { get; set; }

        public DbSet<PetshopApp.Models.Produto> Produto { get; set; }

        public DbSet<PetshopApp.Models.Animal> Animal { get; set; }
    }
