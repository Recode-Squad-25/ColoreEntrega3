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

namespace ColoreEntrega2.Controllers
{
    public class CurriculoesController : Controller
    {
        private readonly Conexao _context;

        public CurriculoesController(Conexao context)
        {
            _context = context;
        }

        // GET: Curriculoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.curriculo.ToListAsync());
        }

        // GET: Curriculoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.curriculo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // GET: Curriculoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Curriculoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Sobrenome,Nome_Social,CPF,RG,Data_Nasc,CEP,Endereco,Numero,Complemento,Bairro,Cidade,UF,Pais,Area_Desejada,Experiencia,Tempo,Escolaridade,Curso,Instituicao")] Curriculo curriculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(curriculo);
        }

        // GET: Curriculoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.curriculo.FindAsync(id);
            if (curriculo == null)
            {
                return NotFound();
            }
            return View(curriculo);
        }

        // POST: Curriculoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sobrenome,Nome_Social,CPF,RG,Data_Nasc,CEP,Endereco,Numero,Complemento,Bairro,Cidade,UF,Pais,Area_Desejada,Experiencia,Tempo,Escolaridade,Curso,Instituicao")] Curriculo curriculo)
        {
            if (id != curriculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curriculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurriculoExists(curriculo.Id))
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
            return View(curriculo);
        }

        // GET: Curriculoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curriculo = await _context.curriculo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // POST: Curriculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curriculo = await _context.curriculo.FindAsync(id);
            _context.curriculo.Remove(curriculo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculoExists(int id)
        {
            return _context.curriculo.Any(e => e.Id == id);
        }
    }
}
