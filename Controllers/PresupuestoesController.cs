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
    public class PresupuestoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PresupuestoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Presupuestoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Presupuestos.Include(p => p.Detalle_presupuesto).Include(p => p.Equipo).Include(p => p.Tecnico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Presupuestoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presupuesto = await _context.Presupuestos
                .Include(p => p.Detalle_presupuesto)
                .Include(p => p.Equipo)
                .Include(p => p.Tecnico)
                .FirstOrDefaultAsync(m => m.Id_Presupuesto == id);
            if (presupuesto == null)
            {
                return NotFound();
            }

            return View(presupuesto);
        }

        // GET: Presupuestoes/Create
        public IActionResult Create()
        {
            ViewData["Id_detalle_Presupuesto"] = new SelectList(_context.detalle_Presupuestos, "Id_detalle_Presupuesto", "Id_detalle_Presupuesto");
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo");
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico");
            return View();
        }

        // POST: Presupuestoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Presupuesto,Total_Pagar_Presupuesto,Hora_Presupuesto,Fecha_presupuesto,Id_Equipo,Id_Tecnico,Id_detalle_Presupuesto")] Presupuesto presupuesto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(presupuesto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_detalle_Presupuesto"] = new SelectList(_context.detalle_Presupuestos, "Id_detalle_Presupuesto", "Id_detalle_Presupuesto", presupuesto.Id_detalle_Presupuesto);
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo", presupuesto.Id_Equipo);
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico", presupuesto.Id_Tecnico);
            return View(presupuesto);
        }

        // GET: Presupuestoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presupuesto = await _context.Presupuestos.FindAsync(id);
            if (presupuesto == null)
            {
                return NotFound();
            }
            ViewData["Id_detalle_Presupuesto"] = new SelectList(_context.detalle_Presupuestos, "Id_detalle_Presupuesto", "Id_detalle_Presupuesto", presupuesto.Id_detalle_Presupuesto);
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo", presupuesto.Id_Equipo);
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico", presupuesto.Id_Tecnico);
            return View(presupuesto);
        }

        // POST: Presupuestoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Presupuesto,Total_Pagar_Presupuesto,Hora_Presupuesto,Fecha_presupuesto,Id_Equipo,Id_Tecnico,Id_detalle_Presupuesto")] Presupuesto presupuesto)
        {
            if (id != presupuesto.Id_Presupuesto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(presupuesto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresupuestoExists(presupuesto.Id_Presupuesto))
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
            ViewData["Id_detalle_Presupuesto"] = new SelectList(_context.detalle_Presupuestos, "Id_detalle_Presupuesto", "Id_detalle_Presupuesto", presupuesto.Id_detalle_Presupuesto);
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo", presupuesto.Id_Equipo);
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico", presupuesto.Id_Tecnico);
            return View(presupuesto);
        }

        // GET: Presupuestoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presupuesto = await _context.Presupuestos
                .Include(p => p.Detalle_presupuesto)
                .Include(p => p.Equipo)
                .Include(p => p.Tecnico)
                .FirstOrDefaultAsync(m => m.Id_Presupuesto == id);
            if (presupuesto == null)
            {
                return NotFound();
            }

            return View(presupuesto);
        }

        // POST: Presupuestoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var presupuesto = await _context.Presupuestos.FindAsync(id);
            _context.Presupuestos.Remove(presupuesto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PresupuestoExists(int id)
        {
            return _context.Presupuestos.Any(e => e.Id_Presupuesto == id);
        }
    }
}
