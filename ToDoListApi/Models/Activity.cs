using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApi.Models
{
    public class Activity
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
      
        public string ShortDescription { get; set; }
       
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime DueTime { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime InsertedAt { get; set; }
    
    }
}
