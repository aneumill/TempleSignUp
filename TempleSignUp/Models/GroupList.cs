using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    //This will add in new groups that sign up and fill out the form
    public class GroupList
    {
        private static List<SignUpModel> group_list = new List<SignUpModel>();

        public static IEnumerable<SignUpModel> TourGroup => group_list;

        public static void AddGroup(SignUpModel group)
        {
            //adds the group to the Sqlite database so it can be accessed when website is closed
            group_list.Add(group);
        }
    }
}