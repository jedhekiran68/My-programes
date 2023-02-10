using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ef_allProperty.Models
{
    public class familycontext:DbContext
    {

        public DbSet<family> f1 { get; set; }

    }
}