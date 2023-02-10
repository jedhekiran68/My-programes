using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ef_create_insert.Models
{
    public class company
    {

        [Key]
        public int eid { get; set; }
        public string ename { get; set; }
        public string eaddress { get; set; }
        public string emobile_no{ get; set; }

        public int esalary { get; set; }
    }
}