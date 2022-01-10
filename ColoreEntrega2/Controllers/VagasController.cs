#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ColoreEntrega2.Models;
using Colore_Entrega2.Models;
using Microsoft.AspNetCore.Authorization;

namespace ColoreEntrega2.Controllers
{
    public class VagasController : Controller
    {
        private readonly Conexao _context;

        public VagasController(Conexao context)
        {
            _context = context;
        }

        // GET: Vagas
        public IActionResult Index(string busca)
        {
            var vagas = from s in _context.vagas select s;

            if (!String.IsNullOrEmpty(busca))
            {
                vagas = vagas.Where(s => s.area.ToUpper().Contains(busca.ToUpper()) || s.escolaridade.ToUpper().Contains(busca.ToUpper()));
            }
            return View(vagas);
        }

        // GET: Vagas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vagas = await _context.vagas
                .FirstOrDefaultAsync(m => m.id == id);
            if (vagas == null)
            {
                return NotFound();
            }

            return View(vagas);
        }

        // GET: Vagas/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vagas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,titulo,salario,descricao,beneficios,area,escolaridade,experiencia,experienciaArea,idiomas,idEmpresa")] Vagas vagas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vagas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vagas);
        }

        // GET: Vagas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vagas = await _context.vagas.FindAsync(id);
            if (vagas == null)
            {
                return NotFound();
            }
            return View(vagas);
        }

        // POST: Vagas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("id,titulo,salario,descricao,beneficios,area,escolaridade,experiencia,experienciaArea,idiomas,idEmpresa")] Vagas vagas)
        {
            if (id != vagas.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vagas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VagasExists(vagas.id))
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
            return View(vagas);
        }

        // GET: Vagas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vagas = await _context.vagas
                .FirstOrDefaultAsync(m => m.id == id);
            if (vagas == null)
            {
                return NotFound();
            }

            return View(vagas);
        }

        // POST: Vagas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var vagas = await _context.vagas.FindAsync(id);
            _context.vagas.Remove(vagas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VagasExists(int? id)
        {
            return _context.vagas.Any(e => e.id == id);
        }
    }
}
