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
    public class MaterialesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaterialesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Materiales
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Materiales1.Include(m => m.Proveedor);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Materiales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiales = await _context.Materiales1
                .Include(m => m.Proveedor)
                .FirstOrDefaultAsync(m => m.Id_Materiales == id);
            if (materiales == null)
            {
                return NotFound();
            }

            return View(materiales);
        }

        // GET: Materiales/Create
        public IActionResult Create()
        {
            ViewData["Id_Proveedor"] = new SelectList(_context.Proveedores, "Id_Proveedor", "Ciudad_Proveedor");
            return View();
        }

        // POST: Materiales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Materiales,Nombre_Materiales,Descripcion_materiales,Precio_Materiales,Existencias_Materiales,Id_Proveedor")] Materiales materiales)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materiales);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Proveedor"] = new SelectList(_context.Proveedores, "Id_Proveedor", "Ciudad_Proveedor", materiales.Id_Proveedor);
            return View(materiales);
        }

        // GET: Materiales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiales = await _context.Materiales1.FindAsync(id);
            if (materiales == null)
            {
                return NotFound();
            }
            ViewData["Id_Proveedor"] = new SelectList(_context.Proveedores, "Id_Proveedor", "Ciudad_Proveedor", materiales.Id_Proveedor);
            return View(materiales);
        }

        // POST: Materiales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Materiales,Nombre_Materiales,Descripcion_materiales,Precio_Materiales,Existencias_Materiales,Id_Proveedor")] Materiales materiales)
        {
            if (id != materiales.Id_Materiales)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materiales);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialesExists(materiales.Id_Materiales))
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
            ViewData["Id_Proveedor"] = new SelectList(_context.Proveedores, "Id_Proveedor", "Ciudad_Proveedor", materiales.Id_Proveedor);
            return View(materiales);
        }

        // GET: Materiales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiales = await _context.Materiales1
                .Include(m => m.Proveedor)
                .FirstOrDefaultAsync(m => m.Id_Materiales == id);
            if (materiales == null)
            {
                return NotFound();
            }

            return View(materiales);
        }

        // POST: Materiales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materiales = await _context.Materiales1.FindAsync(id);
            _context.Materiales1.Remove(materiales);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaterialesExists(int id)
        {
            return _context.Materiales1.Any(e => e.Id_Materiales == id);
        }
    }
}
