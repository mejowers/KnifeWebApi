using KnifeWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeWebApi.Data {
    public class KnifeDbContext  : DbContext {

        //DbSets go here

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Knife> Knives { get; set; }
        public virtual DbSet<CostAndSale> CostAndSales { get; set; }

        public KnifeDbContext(DbContextOptions<KnifeDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }

    }
}
