using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ef_1.Models
{
    public class staffcontext :DbContext 
    {

        public DbSet<staff> s1 { get; set; }



    }
}