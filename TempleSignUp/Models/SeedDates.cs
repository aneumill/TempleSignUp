using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class SeedDates
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            TourGroupContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TourGroupContext>();

            //Will migrate the data if there isn't already
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();

            }

            //if there aren't any changes in times, load up the seed data
            if (!context.Times.Any())
            {
                context.Times.AddRange(
             //Populates the database with seed data that's hardcoded below

             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 8, 0, 0)
             },
             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 9, 0, 0)
             },
             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 10, 0, 0)
             },
             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 11, 0, 0)
             },
             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 12, 0, 0)
             },
             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 13, 0, 0)
             },
             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 14, 0, 0)
             },
             new SlottedTime
             {
                 Schedule = new DateTime(2021, 03, 17, 15, 0, 0)
             },
              new SlottedTime
              {
                  Schedule = new DateTime(2021, 03, 17, 16, 0, 0)
              },

               new SlottedTime
               {
                   Schedule = new DateTime(2021, 03, 17, 17, 0, 0)
               },

                new SlottedTime
                {
                    Schedule = new DateTime(2021, 03, 17, 18, 0, 0)
                },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 17, 19, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 17, 20, 0, 0)
                 },
                 //Next Day 
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 8, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 9, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 10, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 11, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 12, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 13, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 14, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 15, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 16, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 17, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 18, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 19, 0, 0)
                 },
                 new SlottedTime
                 {
                     Schedule = new DateTime(2021, 03, 18, 20, 0, 0)
                 },
                  //Next Day
                  new SlottedTime
                  {
                      Schedule = new DateTime(2021, 03, 19, 8, 0, 0)
                  },
                   new SlottedTime
                   {
                       Schedule = new DateTime(2021, 03, 19, 9, 0, 0)
                   },
                    new SlottedTime
                    {
                        Schedule = new DateTime(2021, 03, 19, 10, 0, 0)
                    },
                     new SlottedTime
                     {
                         Schedule = new DateTime(2021, 03, 19, 11, 0, 0)
                     },
                      new SlottedTime
                      {
                          Schedule = new DateTime(2021, 03, 19, 12, 0, 0)
                      },
                       new SlottedTime
                       {
                           Schedule = new DateTime(2021, 03, 19, 13, 0, 0)
                       },
                        new SlottedTime
                        {
                            Schedule = new DateTime(2021, 03, 19, 14, 0, 0)
                        },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 19, 15, 0, 0)
                         },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 19, 16, 0, 0)
                         },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 19, 17, 0, 0)
                         },
                          new SlottedTime
                          {
                              Schedule = new DateTime(2021, 03, 19, 19, 0, 0)
                          },
                          new SlottedTime
                          {
                              Schedule = new DateTime(2021, 03, 19, 20, 0, 0)
                          },
                           //Next Day
                           new SlottedTime
                           {
                               Schedule = new DateTime(2021, 03, 20, 8, 0, 0)
                           },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 20, 9, 0, 0)
                         },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 20, 10, 0, 0)
                         },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 20, 11, 0, 0)
                         },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 20, 12, 0, 0)
                         },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 20, 13, 0, 0)
                         },
                         new SlottedTime
                         {
                             Schedule = new DateTime(2021, 03, 20, 14, 0, 0)
                         },
                          new SlottedTime
                          {
                              Schedule = new DateTime(2021, 03, 20, 15, 0, 0)
                          },
                           new SlottedTime
                           {
                               Schedule = new DateTime(2021, 03, 20, 16, 0, 0)
                           },
                            new SlottedTime
                            {
                                Schedule = new DateTime(2021, 03, 20, 17, 0, 0)
                            },
                             new SlottedTime
                             {
                                 Schedule = new DateTime(2021, 03, 20, 18, 0, 0)
                             },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 20, 19, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 20, 20, 0, 0)
                              },
                              //Next Day
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 8, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 9, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 10, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 11, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 12, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 13, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 14, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 15, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 16, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 17, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 18, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 19, 0, 0)
                              },
                              new SlottedTime
                              {
                                  Schedule = new DateTime(2021, 03, 21, 20, 0, 0)
                              },
                               //Next Day
                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 8, 0, 0)
                               },
                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 9, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 10, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 11, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 12, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 13, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 14, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 15, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 16, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 17, 0, 0)
                               },

                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 18, 0, 0)
                               },
                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 19, 0, 0)
                               },
                               new SlottedTime
                               {
                                   Schedule = new DateTime(2021, 03, 22, 20, 0, 0)
                               },
                                //Next Day
                                new SlottedTime
                                {
                                    Schedule = new DateTime(2021, 03, 23, 8, 0, 0)
                                },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 9, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 10, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 11, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 12, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 13, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 14, 0, 0)

                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 15, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 16, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 17, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 18, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 19, 0, 0)
                                 },
                                 new SlottedTime
                                 {
                                     Schedule = new DateTime(2021, 03, 23, 20, 0, 0)
                                 });
                //Save Changes
                context.SaveChanges();


            }
        }
    }
}
