using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Models;

namespace test.Controllers
{
    [Authorize]
    public class ActividadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActividadController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Actividad
        ////[Authorize(Roles = "Agente")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actividades.ToListAsync());
        }
        // GET: Actividad/dashboard
        //[Authorize(Roles = "Supervisor")]
        public  IActionResult dashboard()
        {
            return View();
        }

        // GET: Actividad/Create
        //[Authorize(Roles = "Agente")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actividad/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Duracion_llamada,Descripcion,Fecha,Tipo,Resolvio,Id_user")] Actividad actividad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actividad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actividad);
        }

        // GET: Actividad/Edit/5
        //[Authorize(Roles = "Agente")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }
            return View(actividad);
        }

        // POST: Actividad/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Duracion_llamada,Descripcion,Fecha,Tipo,Resolvio,Id_user")] Actividad actividad)
        {
            if (id != actividad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actividad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActividadExists(actividad.Id))
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
            return View(actividad);
        }

        // GET: Actividad/Delete/5
        //[Authorize(Roles = "Agente")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actividad = await _context.Actividades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // POST: Actividad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actividad = await _context.Actividades.FindAsync(id);
            _context.Actividades.Remove(actividad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActividadExists(int id)
        {
            return _context.Actividades.Any(e => e.Id == id);
        }
    }
}
