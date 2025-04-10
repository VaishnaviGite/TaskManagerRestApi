using Microsoft.AspNetCore.Mvc;
using TaskManagerRestApi.Context;

namespace TaskManagerRestApi.Controllers
{
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _context;

        public TaskController(TaskContext context)
        {
            _context = context;
        }


    }
}
