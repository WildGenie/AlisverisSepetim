using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlisverisSepetim.Models;

namespace AlisverisSepetim.Data
{
    public class AlisverisSepetimContext : DbContext
    {
        public AlisverisSepetimContext (DbContextOptions<AlisverisSepetimContext> options)
            : base(options)
        {
        }

        public DbSet<AlisverisSepetim.Models.Urun> Urun { get; set; }

        public DbSet<AlisverisSepetim.Models.Kategori> Kategori { get; set; }

        public DbSet<AlisverisSepetim.Models.Sepet> Sepet { get; set; }

    }
}
