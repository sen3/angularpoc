using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManagementApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}