using DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TaskManagementApp.Models;

namespace TaskManagementApp.Controllers
{
    public class TaskController : ApiController
    {
        // GET: api/Task
        public IEnumerable<TodoItem> Get()
        {

        
            return DataService.Instance.GetTasks();

            //return tasks;
        }

        // GET: api/Task/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Task
        public void Post([FromBody]TodoItem value)
        {
            DataService.Instance.addTask(value);
        
        }

        // PUT: api/Task/5
        public void Put(int id, [FromBody]TodoItem value)
        {
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
        }
    }
}
