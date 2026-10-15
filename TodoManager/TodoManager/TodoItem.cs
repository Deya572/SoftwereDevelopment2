using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class TodoItem
    {
        public int ID { get; set; }

        public string Title
        {
            get
            {
                return Title;
            }
            set
            {
                if (string.IsNullOrEmpty(Title))
                    throw new ArgumentNullException("Заглавието е задължително!");
            }
        }
        public string Description { get; set; }
        
        public int Id { get; set; }
        public DateTime OverTime { get; set; }

        public bool IsCompleted { get; set; }

        public TodoItem(string title, string description, DateTime OverTime)
        {
            if (ID <= 0)
                throw new ArgumentOutOfRangeException("ID трябва да е положително ");
            if(string.IsNullOrEmpty(title))
                throw new ArgumentNullException("Заглавието е задължително");
            Title = title;
            ID = ID;
            Description = description;
            OverTime = OverTime;
            IsCompleted = false;
        }


    }

}
