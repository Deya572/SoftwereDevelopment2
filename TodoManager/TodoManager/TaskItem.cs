using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        
        public bool IsCompleted { get; set; }

        public TaskItem(string title, string description, DateTime )
        {
            Title = title;
            Description = description;
            
            IsCompleted = false;
        }

        
    }
}
