using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Novena_Dsahboard.Models;

namespace Novena_Dsahboard.Controllers
{
    public class ScientificsController : Controller
    {
        private readonly Novena_DsahboardContext _context;

        public ScientificsController(Novena_DsahboardContext context)
        {
            _context = context;
        }

        // GET: Scientifics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Scientific.ToListAsync());
        }

        // GET: Scientifics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scientific = await _context.Scientific
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scientific == null)
            {
                return NotFound();
            }

            return View(scientific);
        }

        // GET: Scientifics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Scientifics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProImage,Title,Price,DiscountPrice")] Scientific scientific)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scientific);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scientific);
        }

        // GET: Scientifics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scientific = await _context.Scientific.FindAsync(id);
            if (scientific == null)
            {
                return NotFound();
            }
            return View(scientific);
        }

        // POST: Scientifics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProImage,Title,Price,DiscountPrice")] Scientific scientific)
        {
            if (id != scientific.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scientific);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScientificExists(scientific.Id))
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
            return View(scientific);
        }

        // GET: Scientifics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scientific = await _context.Scientific
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scientific == null)
            {
                return NotFound();
            }

            return View(scientific);
        }

        // POST: Scientifics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scientific = await _context.Scientific.FindAsync(id);
            _context.Scientific.Remove(scientific);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScientificExists(int id)
        {
            return _context.Scientific.Any(e => e.Id == id);
        }
    }
}
