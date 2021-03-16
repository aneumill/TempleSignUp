using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class GroupList
    {
        private static List<SignUpModel> group_list = new List<SignUpModel>();

        public static IEnumerable<SignUpModel> TourGroup => group_list;

        public static void AddGroup(SignUpModel group)
        {
            group_list.Add(group);
        }
    }
}