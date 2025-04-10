using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerRestApi.Context;
using TaskManagerRestApi.Models;

namespace TaskManagerRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _context;

        public TaskController(TaskContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Items>>> GetAllTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Items>> GetTaskById(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
                return NotFound(new { message = "Task not found." });

            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<Items>> CreateTask(Items task)
        {
            if (string.IsNullOrWhiteSpace(task.Title))
                return BadRequest(new { message = "Title is required." });

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
        }

    }
}
