using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class TodoSurvice
    {
        private readonly List<TodoItem> todos = new List<TodoItem>();
        private static int nextId = 1;

        public List<TodoItem> GetAll()
        {
            return todos;
        }

        public TodoItem FindById(int id)
        {

            foreach (TodoItem t in todos)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }

            return null;

        }
        public void Add(string title, string description, DateTime dueDate)
        {
            TodoItem todoItem = new TodoItem(nextId, title, description, dueDate);
            todos.Add(todoItem);
            nextId++;
        }

        public void Complite(int id)
        {
            TodoItem completedTask = FindById(id);


            if (completedTask == null)
                throw new ArgumentException("Няма задача с такова ID");

            completedTask.Completed();
        }
        public void Delete(int id)
        {
            TodoItem deleteTask = FindById(id);

            if (deleteTask == null)
                throw new ArgumentException("Nqma takava zadacha sus takova Id");
            todos.Remove(deleteTask);
        }
    }
}

