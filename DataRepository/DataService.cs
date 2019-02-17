using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Models;

namespace DataRepository
{
    public class DataService
    {

        static readonly DataService _instance = new DataService();
        public static DataService Instance
        {
            get
            {
                return _instance;
            }
        }
        List<TodoItem> Tasks;

        DataService()
        {
            //List<TodoItem> tasks = new List<TodoItem>()
            //{
            //    new TodoItem() { Id=0, Description="Task 1", CreatedTime = DateTime.Now },
            //    new TodoItem() { Id=1, Description="Task 2", CreatedTime = DateTime.Now, IsCompleted=true },
            //    new TodoItem() { Id=2, Description="Task 3", CreatedTime = DateTime.Now, IsCompleted=true },
            //    new TodoItem() { Id=3, Description="Task 4", CreatedTime = DateTime.Now },
            //    new TodoItem() { Id=0, Description="Task 5", CreatedTime = DateTime.Now },
            //    new TodoItem() { Id=0, Description="Task 6", CreatedTime = DateTime.Now },
            //};
            Tasks = new List<TodoItem>();
        }
        public void addTask(TodoItem todoItem)
        {
            Tasks.Add(todoItem);
        }

        public IEnumerable<TodoItem> GetTasks()
        {
            return Tasks;
        }
    }
}
