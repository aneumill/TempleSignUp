using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models.ViewModel
{
    //Method to combine both the groups database and the times database
    public class ViewApppointmentList
    {
        //gathers information from the groups database and times database to connect group with their selected booking time
        public SlottedTime slottedtime { get; set; }
        public SignUpModel signup { get; set; }


    }
}
