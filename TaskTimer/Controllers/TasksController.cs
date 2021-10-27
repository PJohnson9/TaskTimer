using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskTimer.Data;
using TaskTimer.Models;

namespace TaskTimer.Controllers
{
    public class TasksController : Controller
    {
        private readonly TaskTimerDbContext _context;

        public TasksController(TaskTimerDbContext context)
        {
            _context = context;
        }

        // GET: Tasks
        public async Task<IActionResult> Index()
        {
            var taskTimerDbContext = _context.Tasks.Include(w => w.Category);
            return View(await taskTimerDbContext.ToListAsync());
        }

        // GET: Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workTask = await _context.Tasks
                .Include(w => w.Category)
                .FirstOrDefaultAsync(m => m.TaskID == id);
            if (workTask == null)
            {
                return NotFound();
            }

            return View(workTask);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "TaskCategoryID", "Category");
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskID,UserID,Name,CategoryID,Category,Completed")] WorkTask workTask)
        {
            // TODO: Figure out why I have to do this.  
            ModelState.ClearValidationState("Category");
            ModelState.MarkFieldValid("Category");

            if (ModelState.IsValid)
            {
                _context.Add(workTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "TaskCategoryID", "Category", workTask.CategoryID);
            return View(workTask);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workTask = await _context.Tasks.FindAsync(id);
            if (workTask == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "TaskCategoryID", "Category", workTask.CategoryID);
            return View(workTask);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskID,UserID,Name,CategoryID,Completed")] WorkTask workTask)
        {
            if (id != workTask.TaskID)
            {
                return NotFound();
            }

            // TODO: Figure out why I have to do this.  
            ModelState.ClearValidationState("Category");
            ModelState.MarkFieldValid("Category");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkTaskExists(workTask.TaskID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "TaskCategoryID", "Category", workTask.CategoryID);
            return View(workTask);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workTask = await _context.Tasks
                .Include(w => w.Category)
                .FirstOrDefaultAsync(m => m.TaskID == id);
            if (workTask == null)
            {
                return NotFound();
            }

            return View(workTask);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workTask = await _context.Tasks.FindAsync(id);
            _context.Tasks.Remove(workTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkTaskExists(int id)
        {
            return _context.Tasks.Any(e => e.TaskID == id);
        }
    }
}
