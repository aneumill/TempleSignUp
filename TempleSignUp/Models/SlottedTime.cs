using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    //Properties for all the possible time slots that groups can choose from
    public class SlottedTime
    {
        //The key generated by Asp.Net to ID each individual time slot
        [Key]
        public int SlottedTimeID { get; set; }
        //The Schedule which keeps track of the actual day and time of the slot
        public DateTime Schedule { get; set; }
        //Marked as true if the time slot hasn't been selected yet. 
        //When selected, will become false.
        //So the starting default is true
        public bool Availbility { get; set; } = true;



    }
}
