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
    public class CasestudiesController : Controller
    {
        private readonly Novena_DsahboardContext _context;

        public CasestudiesController(Novena_DsahboardContext context)
        {
            _context = context;
        }

        // GET: Casestudies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Casestudy.ToListAsync());
        }

        // GET: Casestudies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casestudy = await _context.Casestudy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (casestudy == null)
            {
                return NotFound();
            }

            return View(casestudy);
        }

        // GET: Casestudies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Casestudies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Image,Date")] Casestudy casestudy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casestudy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(casestudy);
        }

        // GET: Casestudies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casestudy = await _context.Casestudy.FindAsync(id);
            if (casestudy == null)
            {
                return NotFound();
            }
            return View(casestudy);
        }

        // POST: Casestudies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Image,Date")] Casestudy casestudy)
        {
            if (id != casestudy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casestudy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasestudyExists(casestudy.Id))
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
            return View(casestudy);
        }

        // GET: Casestudies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casestudy = await _context.Casestudy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (casestudy == null)
            {
                return NotFound();
            }

            return View(casestudy);
        }

        // POST: Casestudies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casestudy = await _context.Casestudy.FindAsync(id);
            _context.Casestudy.Remove(casestudy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CasestudyExists(int id)
        {
            return _context.Casestudy.Any(e => e.Id == id);
        }
    }
}
