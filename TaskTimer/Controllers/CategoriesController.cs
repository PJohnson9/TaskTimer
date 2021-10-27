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
    public class CategoriesController : Controller
    {
        private readonly TaskTimerDbContext _context;

        public CategoriesController(TaskTimerDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskCategory = await _context.Categories
                .FirstOrDefaultAsync(m => m.TaskCategoryID == id);
            if (taskCategory == null)
            {
                return NotFound();
            }

            return View(taskCategory);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskCategoryID,Category")] TaskCategory taskCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskCategory);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskCategory = await _context.Categories.FindAsync(id);
            if (taskCategory == null)
            {
                return NotFound();
            }
            return View(taskCategory);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskCategoryID,Category")] TaskCategory taskCategory)
        {
            if (id != taskCategory.TaskCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskCategoryExists(taskCategory.TaskCategoryID))
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
            return View(taskCategory);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskCategory = await _context.Categories
                .FirstOrDefaultAsync(m => m.TaskCategoryID == id);
            if (taskCategory == null)
            {
                return NotFound();
            }

            return View(taskCategory);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskCategory = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(taskCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskCategoryExists(int id)
        {
            return _context.Categories.Any(e => e.TaskCategoryID == id);
        }
    }
}
