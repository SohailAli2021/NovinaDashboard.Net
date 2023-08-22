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
    public class WebServicesController : Controller
    {
        private readonly Novena_DsahboardContext _context;

        public WebServicesController(Novena_DsahboardContext context)
        {
            _context = context;
        }

        // GET: WebServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.WebService.ToListAsync());
        }

        // GET: WebServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webService = await _context.WebService
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webService == null)
            {
                return NotFound();
            }

            return View(webService);
        }

        // GET: WebServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WebServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Heading,Description,Picture")] WebService webService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(webService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(webService);
        }

        // GET: WebServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webService = await _context.WebService.FindAsync(id);
            if (webService == null)
            {
                return NotFound();
            }
            return View(webService);
        }

        // POST: WebServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Heading,Description,Picture")] WebService webService)
        {
            if (id != webService.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(webService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebServiceExists(webService.Id))
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
            return View(webService);
        }

        // GET: WebServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var webService = await _context.WebService
                .FirstOrDefaultAsync(m => m.Id == id);
            if (webService == null)
            {
                return NotFound();
            }

            return View(webService);
        }

        // POST: WebServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var webService = await _context.WebService.FindAsync(id);
            _context.WebService.Remove(webService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebServiceExists(int id)
        {
            return _context.WebService.Any(e => e.Id == id);
        }
    }
}
