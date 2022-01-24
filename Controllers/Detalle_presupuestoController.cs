using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppSenaJmoc.Data;
using AppSenaJmoc.Models;

namespace AppSenaJmoc.Controllers
{
    public class Detalle_presupuestoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Detalle_presupuestoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Detalle_presupuesto
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.detalle_Presupuestos.Include(d => d.Materiales);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Detalle_presupuesto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_presupuesto = await _context.detalle_Presupuestos
                .Include(d => d.Materiales)
                .FirstOrDefaultAsync(m => m.Id_detalle_Presupuesto == id);
            if (detalle_presupuesto == null)
            {
                return NotFound();
            }

            return View(detalle_presupuesto);
        }

        // GET: Detalle_presupuesto/Create
        public IActionResult Create()
        {
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales");
            return View();
        }

        // POST: Detalle_presupuesto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_detalle_Presupuesto,Cantidad_detalle_Presupuesto,Id_Materiales")] Detalle_presupuesto detalle_presupuesto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalle_presupuesto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales", detalle_presupuesto.Id_Materiales);
            return View(detalle_presupuesto);
        }

        // GET: Detalle_presupuesto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_presupuesto = await _context.detalle_Presupuestos.FindAsync(id);
            if (detalle_presupuesto == null)
            {
                return NotFound();
            }
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales", detalle_presupuesto.Id_Materiales);
            return View(detalle_presupuesto);
        }

        // POST: Detalle_presupuesto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_detalle_Presupuesto,Cantidad_detalle_Presupuesto,Id_Materiales")] Detalle_presupuesto detalle_presupuesto)
        {
            if (id != detalle_presupuesto.Id_detalle_Presupuesto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalle_presupuesto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Detalle_presupuestoExists(detalle_presupuesto.Id_detalle_Presupuesto))
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
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales", detalle_presupuesto.Id_Materiales);
            return View(detalle_presupuesto);
        }

        // GET: Detalle_presupuesto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_presupuesto = await _context.detalle_Presupuestos
                .Include(d => d.Materiales)
                .FirstOrDefaultAsync(m => m.Id_detalle_Presupuesto == id);
            if (detalle_presupuesto == null)
            {
                return NotFound();
            }

            return View(detalle_presupuesto);
        }

        // POST: Detalle_presupuesto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalle_presupuesto = await _context.detalle_Presupuestos.FindAsync(id);
            _context.detalle_Presupuestos.Remove(detalle_presupuesto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Detalle_presupuestoExists(int id)
        {
            return _context.detalle_Presupuestos.Any(e => e.Id_detalle_Presupuesto == id);
        }
    }
}
