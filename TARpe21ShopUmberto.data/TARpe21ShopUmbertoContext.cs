using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TARpe21ShopUmberto.Core.Domain;

namespace TARpe21ShopUmberto.Data
{
    public class TARpe21ShopUmbertoContext : DbContext
    {
        public TARpe21ShopUmbertoContext(DbContextOptions<TARpe21ShopUmbertoContext> options) : base(options) { }

        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<FileToDatabase> FilesToDatabase { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<FileToApi> FilesToApi { get; set; }
    }
}
