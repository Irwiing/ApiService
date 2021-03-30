using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Cliente>().HasOne(e => e.Endereco);
            base.OnModelCreating(model);
        }
    }
