using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ef_2.Models
{
    public class collegecontext : DbContext
    {
      
        public DbSet<college> c1 { get; set; }


    }
}