using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace TempleSignUp.Models
{
    public class SignUpModel
    {
        [Required, Key]
        public int GroupID { get; set; }
        [Required(ErrorMessage = "Please enter a group name")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Please enter the number of people in your group")]
        public int GroupSize { get; set;}
        [Required(ErrorMessage = "Please enter your email address") , EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone number must be 10 digits. Ex. 111-111-1111 or 111.111.1111 or 1111111111")]
        public string PhoneNumber { get; set;  }
        [Required]
        public string TourTime { get; set; }

    }
}
