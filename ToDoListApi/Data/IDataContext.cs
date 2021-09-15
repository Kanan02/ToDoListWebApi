using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ToDoListApi.Models;

namespace ToDoListApi.Data
{
    public interface IDataContext
    {
        DbSet<Activity> Activities { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
