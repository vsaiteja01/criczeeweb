using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cricZee.Models;

namespace cricZee.Controllers
{
    public class SignController : Controller
    {
        private readonly dbContext _context;

        public SignController(dbContext context)
        {
            _context = context;
        }

        // GET: Sign
        public async Task<IActionResult> Index()
        {
            return View(await _context.Demos.ToListAsync());
        }

        // GET: Sign/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demo = await _context.Demos
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (demo == null)
            {
                return NotFound();
            }

            return View(demo);
        }

        // GET: Sign/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sign/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,Userpassword")] Demo demo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login","Account");
            }
            return View(demo);
        }

        // GET: Sign/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demo = await _context.Demos.FindAsync(id);
            if (demo == null)
            {
                return NotFound();
            }
            return View(demo);
        }

        // POST: Sign/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserName,Userpassword")] Demo demo)
        {
            if (id != demo.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemoExists(demo.UserName))
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
            return View(demo);
        }

        // GET: Sign/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demo = await _context.Demos
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (demo == null)
            {
                return NotFound();
            }

            return View(demo);
        }

        // POST: Sign/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var demo = await _context.Demos.FindAsync(id);
            _context.Demos.Remove(demo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemoExists(string id)
        {
            return _context.Demos.Any(e => e.UserName == id);
        }
    }
}
