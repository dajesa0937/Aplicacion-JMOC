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
    public class Detalle_facturaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Detalle_facturaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Detalle_factura
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.detalle_Facturas.Include(d => d.Materiales);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Detalle_factura/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_factura = await _context.detalle_Facturas
                .Include(d => d.Materiales)
                .FirstOrDefaultAsync(m => m.Id_Detalle_factura == id);
            if (detalle_factura == null)
            {
                return NotFound();
            }

            return View(detalle_factura);
        }

        // GET: Detalle_factura/Create
        public IActionResult Create()
        {
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales");
            return View();
        }

        // POST: Detalle_factura/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Detalle_factura,Cantidad_Detalle,Id_Materiales")] Detalle_factura detalle_factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalle_factura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales", detalle_factura.Id_Materiales);
            return View(detalle_factura);
        }

        // GET: Detalle_factura/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_factura = await _context.detalle_Facturas.FindAsync(id);
            if (detalle_factura == null)
            {
                return NotFound();
            }
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales", detalle_factura.Id_Materiales);
            return View(detalle_factura);
        }

        // POST: Detalle_factura/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Detalle_factura,Cantidad_Detalle,Id_Materiales")] Detalle_factura detalle_factura)
        {
            if (id != detalle_factura.Id_Detalle_factura)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalle_factura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Detalle_facturaExists(detalle_factura.Id_Detalle_factura))
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
            ViewData["Id_Materiales"] = new SelectList(_context.Materiales1, "Id_Materiales", "Descripcion_materiales", detalle_factura.Id_Materiales);
            return View(detalle_factura);
        }

        // GET: Detalle_factura/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle_factura = await _context.detalle_Facturas
                .Include(d => d.Materiales)
                .FirstOrDefaultAsync(m => m.Id_Detalle_factura == id);
            if (detalle_factura == null)
            {
                return NotFound();
            }

            return View(detalle_factura);
        }

        // POST: Detalle_factura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalle_factura = await _context.detalle_Facturas.FindAsync(id);
            _context.detalle_Facturas.Remove(detalle_factura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Detalle_facturaExists(int id)
        {
            return _context.detalle_Facturas.Any(e => e.Id_Detalle_factura == id);
        }
    }
}
