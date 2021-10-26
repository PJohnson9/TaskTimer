using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTimer.Data;
using TaskTimer.Models;

namespace TaskTimer
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskCategoriesController : ControllerBase
    {
        private readonly TaskTimerDbContext _context;

        public TaskCategoriesController(TaskTimerDbContext context)
        {
            _context = context;
        }

        // GET: api/TaskCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskCategory>>> GetTaskCategory()
        {
            return await _context.TaskCategories.ToListAsync();
        }

        // GET: api/TaskCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskCategory>> GetTaskCategory(int id)
        {
            var taskCategory = await _context.TaskCategories.FindAsync(id);

            if (taskCategory == null)
            {
                return NotFound();
            }

            return taskCategory;
        }



        // Not Implemented - API will be for read-only operations


        //// PUT: api/TaskCategories/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTaskCategory(int id, TaskCategory taskCategory)
        //{
        //    if (id != taskCategory.TaskCategoryID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(taskCategory).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TaskCategoryExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/TaskCategories
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<TaskCategory>> PostTaskCategory(TaskCategory taskCategory)
        //{
        //    _context.TaskCategory.Add(taskCategory);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTaskCategory", new { id = taskCategory.TaskCategoryID }, taskCategory);
        //}

        //// DELETE: api/TaskCategories/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTaskCategory(int id)
        //{
        //    var taskCategory = await _context.TaskCategory.FindAsync(id);
        //    if (taskCategory == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TaskCategory.Remove(taskCategory);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool TaskCategoryExists(int id)
        {
            return _context.TaskCategories.Any(e => e.TaskCategoryID == id);
        }
    }
}
