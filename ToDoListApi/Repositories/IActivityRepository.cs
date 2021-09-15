using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListApi.Models;

namespace ToDoListApi.Repositories
{
    public interface IActivityRepository
    {
        Task<Activity> Get(int id);
        Task<IEnumerable<Activity>> GetAll();
        Task Add(Activity activity);
        Task Delete(int id);
        Task Update(Activity activity);
    }
}
