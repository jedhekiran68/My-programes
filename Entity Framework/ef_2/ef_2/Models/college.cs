using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ef_2.Models
{
    public class college
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string pssword { get; set; }
    }
}