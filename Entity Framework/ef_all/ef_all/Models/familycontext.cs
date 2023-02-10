using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ef_all.Models
{
    public class familycontext : DbContext
    {
        public DbSet<family> f1 { get; set; }

    }
}