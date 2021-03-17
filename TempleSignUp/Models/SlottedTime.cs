using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class SlottedTime
    {
        [Key]
        public int SlottedTimeID { get; set; }
        public DateTime Schedule { get; set; }
        public bool Availbility { get; set; } = true; 



    }
}
