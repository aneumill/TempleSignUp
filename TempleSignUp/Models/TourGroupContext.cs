using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    //sets up the Databases for the two tables created
    public class TourGroupContext : DbContext
    {
        public TourGroupContext(DbContextOptions<TourGroupContext> options) : base(options)
        {

        }
        //one table for the sign up groups
        public DbSet<SignUpModel> Groups { get; set; }
        //another table for the slotted time that was selected from the whole list.
        public DbSet<SlottedTime> Times { get; set; }


    }
}
