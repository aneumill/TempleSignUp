using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class TourGroupContext : DbContext 
    {
        public TourGroupContext(DbContextOptions<TourGroupContext> options) : base (options)
        {
            
        }
        public DbSet<SignUpModel> Groups { get; set; }
        public DbSet<SlottedTime> Times { get; set; }
        
       
    }
}
