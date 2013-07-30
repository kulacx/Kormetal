using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Kormetal.Entities.Concrete;

namespace Kormetal.Dal.Concrete.EntityFramework
{
   public class KmContext:DbContext
    {
       public DbSet<KMICERIK> Icerik { get; set; }
       public DbSet<KMICERIKRESIM> IcerikResim { get; set; }
       public DbSet<KMKATEGORI> Kategori { get; set; }
    }
}
