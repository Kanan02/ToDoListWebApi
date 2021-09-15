using ToDoListApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApi.Services
{
    public interface IActivityService
    {
        public IEnumerable<Activity> GetStudents();
        public Activity GetById(long id);
        public Activity Create(Activity item);
        public Activity Update(long id, Activity item);
        public void Delete(long id);
    }
}
