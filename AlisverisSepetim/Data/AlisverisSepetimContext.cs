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

        public DbSet<Urun> Urunler { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
