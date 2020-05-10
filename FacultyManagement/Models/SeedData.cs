using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace FacultyManagement.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Faculty.Any())
            {
                context.Faculty.AddRange(
                    new FacultyResponse
                    {
                        fName = "Alwin",
                        fLastName = "Jain"
                        
                    },
                    new FacultyResponse
                    {
                        fName = "Jerin",
                        fLastName = "Thomas"
                    },
                    new FacultyResponse
                    {
                        fName = "Alga",
                        fLastName = "Alwin"
                    },
                    new FacultyResponse
                    {
                        fName = "Stephy",
                        fLastName = "Babu"
                    }
                   
                );

                


                context.SaveChanges();

            }
        }
    }
}

