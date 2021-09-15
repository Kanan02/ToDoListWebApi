using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListApi.Data;
using ToDoListApi.Models;

namespace ToDoListApi.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly IDataContext _context;
        
        public ActivityRepository(IDataContext context)
        {
            _context = context;
        }
        
        
        public async Task Add(Activity activity)
        {
            activity.InsertedAt = DateTime.Now;
            activity.UpdatedAt = DateTime.Now;
            _context.Activities.Add(activity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var itemToDelete = await _context.Activities.FindAsync(id);
            if (itemToDelete==null)
            {
                throw new NullReferenceException();
            }
            _context.Activities.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Activity> Get(int id)
        {
            return await _context.Activities.FindAsync(id);
        }

        public async Task<IEnumerable<Activity>> GetAll()
        {
            return await _context.Activities.ToListAsync();
        }

        public async Task Update(Activity activity)
        {
            var itemToUpdate = await _context.Activities.FindAsync(activity.Id);
            if (itemToUpdate==null)
            {
                throw new NullReferenceException();
            }
            itemToUpdate.Description = activity.Description;
            itemToUpdate.DueTime = activity.DueTime;
            itemToUpdate.StartTime = activity.StartTime;
            itemToUpdate.Title = activity.Title;
            itemToUpdate.ShortDescription = activity.ShortDescription;
            itemToUpdate.UpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync();
        
        }

    }
}
