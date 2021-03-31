using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Models;

namespace test.Controllers
{
    public class ResolGenreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResolGenreController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ResolGenre
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resols.ToListAsync());
        }

        // GET: ResolGenre/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resol = await _context.Resols
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resol == null)
            {
                return NotFound();
            }

            return View(resol);
        }

        // GET: ResolGenre/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResolGenre/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Resol resol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resol);
        }

        // GET: ResolGenre/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resol = await _context.Resols.FindAsync(id);
            if (resol == null)
            {
                return NotFound();
            }
            return View(resol);
        }

        // POST: ResolGenre/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Resol resol)
        {
            if (id != resol.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResolExists(resol.Id))
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
            return View(resol);
        }

        // GET: ResolGenre/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resol = await _context.Resols
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resol == null)
            {
                return NotFound();
            }

            return View(resol);
        }

        // POST: ResolGenre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resol = await _context.Resols.FindAsync(id);
            _context.Resols.Remove(resol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResolExists(int id)
        {
            return _context.Resols.Any(e => e.Id == id);
        }
    }
}
