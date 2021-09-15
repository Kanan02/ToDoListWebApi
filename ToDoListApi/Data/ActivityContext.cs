using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ToDoListApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApi.Data
{
    public class ActivityContext:DbContext,IDataContext
    {
        public ActivityContext()
        {

        }
        public ActivityContext(DbContextOptions<ActivityContext> options) : base(options)
        {

        }
        public  DbSet<Activity> Students { get; set; }
        public DbSet<Activity> Activities { get ; set ; }

        //public IEnumerable<Activity> GetStudents()
        //{
        //    return Students;
        //}

        //public Activity GetById(long id)
        //{
        //    return Students.FirstOrDefault(t => t.Id == id);
        //}

        //public Activity Create(Activity item)
        //{
        //    item.InsertedAt = DateTime.Now;
        //    item.UpdatedAt = DateTime.Now;

        //    Students.Add(item);
        //    SaveChanges();

        //    return item;
        //}

        //public Activity Update(long id, Activity item)
        //{
        //    var student = Students.FirstOrDefault(t => t.Id == id);
          
        //    student.Id = item.Id;
        //    student.InsertedAt = item.InsertedAt;

        //    student.UpdatedAt = DateTime.Now;
        //    Students.Update(student);
        //    SaveChanges();
        //    return student;
        //}
        //public void Delete(long id)
        //{
        //    var student = Students.FirstOrDefault(t => t.Id == id);
        //    Students.Remove(student);
        //    SaveChanges();
        //}
    }
}
