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
    public class FacturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FacturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Facturas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Facturas.Include(f => f.Detalle_factura).Include(f => f.Equipo).Include(f => f.Tecnico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas
                .Include(f => f.Detalle_factura)
                .Include(f => f.Equipo)
                .Include(f => f.Tecnico)
                .FirstOrDefaultAsync(m => m.Id_factura == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // GET: Facturas/Create
        public IActionResult Create()
        {
            ViewData["Id_Detalle_factura"] = new SelectList(_context.detalle_Facturas, "Id_Detalle_factura", "Id_Detalle_factura");
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo");
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico");
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_factura,Total_pagar_factura,Id_Equipo,Id_Tecnico,Id_Detalle_factura")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Detalle_factura"] = new SelectList(_context.detalle_Facturas, "Id_Detalle_factura", "Id_Detalle_factura", factura.Id_Detalle_factura);
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo", factura.Id_Equipo);
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico", factura.Id_Tecnico);
            return View(factura);
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);
            if (factura == null)
            {
                return NotFound();
            }
            ViewData["Id_Detalle_factura"] = new SelectList(_context.detalle_Facturas, "Id_Detalle_factura", "Id_Detalle_factura", factura.Id_Detalle_factura);
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo", factura.Id_Equipo);
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico", factura.Id_Tecnico);
            return View(factura);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_factura,Total_pagar_factura,Id_Equipo,Id_Tecnico,Id_Detalle_factura")] Factura factura)
        {
            if (id != factura.Id_factura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacturaExists(factura.Id_factura))
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
            ViewData["Id_Detalle_factura"] = new SelectList(_context.detalle_Facturas, "Id_Detalle_factura", "Id_Detalle_factura", factura.Id_Detalle_factura);
            ViewData["Id_Equipo"] = new SelectList(_context.Equipos, "Id_Equipo", "Marca_Equipo", factura.Id_Equipo);
            ViewData["Id_Tecnico"] = new SelectList(_context.Tecnicos, "Id_Tecnico", "Apellidos_Tecnico", factura.Id_Tecnico);
            return View(factura);
        }

        // GET: Facturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas
                .Include(f => f.Detalle_factura)
                .Include(f => f.Equipo)
                .Include(f => f.Tecnico)
                .FirstOrDefaultAsync(m => m.Id_factura == id);
            if (factura == null)
            {
                return NotFound();
            }

            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);
            _context.Facturas.Remove(factura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacturaExists(int id)
        {
            return _context.Facturas.Any(e => e.Id_factura == id);
        }
    }
}
