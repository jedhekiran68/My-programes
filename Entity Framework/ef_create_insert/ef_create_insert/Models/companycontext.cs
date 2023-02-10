using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ef_create_insert.Models
{
    public class companycontext:DbContext
    {
        public DbSet<company> c1 { get; set; }

    }
}