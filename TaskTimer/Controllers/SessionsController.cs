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
    public class SessionsController : Controller
    {
        private readonly TaskTimerDbContext _context;

        public SessionsController(TaskTimerDbContext context)
        {
            _context = context;
        }

        // GET: Sessions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sessions.ToListAsync());
        }

        // GET: Sessions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workSession = await _context.Sessions
                .FirstOrDefaultAsync(m => m.SessionID == id);
            if (workSession == null)
            {
                return NotFound();
            }

            return View(workSession);
        }

        // GET: Sessions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sessions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SessionID,Start,End")] WorkSession workSession)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workSession);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workSession);
        }

        // GET: Sessions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workSession = await _context.Sessions.FindAsync(id);
            if (workSession == null)
            {
                return NotFound();
            }
            return View(workSession);
        }

        // POST: Sessions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SessionID,Start,End")] WorkSession workSession)
        {
            if (id != workSession.SessionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workSession);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkSessionExists(workSession.SessionID))
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
            return View(workSession);
        }

        // GET: Sessions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workSession = await _context.Sessions
                .FirstOrDefaultAsync(m => m.SessionID == id);
            if (workSession == null)
            {
                return NotFound();
            }

            return View(workSession);
        }

        // POST: Sessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workSession = await _context.Sessions.FindAsync(id);
            _context.Sessions.Remove(workSession);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkSessionExists(int id)
        {
            return _context.Sessions.Any(e => e.SessionID == id);
        }
    }
}
