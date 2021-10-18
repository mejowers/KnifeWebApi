using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeWebApi.Data {
    public class KnifeDbContext  : DbContext {

        //DbSets go here

        public KnifeDbContext(DbContextOptions<KnifeDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }

    }
}
