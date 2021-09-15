using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoListApi.Data;
using ToDoListApi.Services;

namespace ToDoListApi.Models
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder application)
        {
            using (var serviceScope = application.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ActivityContext>());
            }
        }
        public static void SeedData(ActivityContext context)
        {
            Console.WriteLine("Appling Migrations..");
            context.Database.Migrate();

            if (!context.Students.Any())
            {
                Console.WriteLine("Adding data - seeding");
                context.Students.AddRange(
                    new Activity()
                    {
                     
                        Description="A",
                        DueTime=DateTime.Now,
                        StartTime=DateTime.Now,
                        ShortDescription="a",
                        Title="Do something",
                        InsertedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                       
                    },
                    new Activity()
                    {
                       
                        Description = "B",
                        DueTime = DateTime.Now,
                        StartTime = DateTime.Now,
                        ShortDescription = "b",
                        Title = "Do something2",
                        InsertedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                     
                    }
                    ) ;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Already have data - not seeding");
            }
        }
    }
}
