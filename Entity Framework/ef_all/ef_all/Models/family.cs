using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ef_all.Models
{
    public class family
    {
        [Key]
        public int fid { get; set; }

        public string name { get; set; }

        public string relation { get; set; }

        public string position { get; set; }

        public string mobile_no { get; set; }

        public string job_location { get; set; }


    }
}