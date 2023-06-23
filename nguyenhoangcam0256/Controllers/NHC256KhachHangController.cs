using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using nguyenhoangcam0256.Models;

namespace nguyenhoangcam0256.Controllers
{
    public class NHC256KhachHangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NHC256KhachHangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NHC256KhachHang
        public async Task<IActionResult> Index()
        {
              return _context.NHC256KhachHang != null ? 
                          View(await _context.NHC256KhachHang.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NHC256KhachHang'  is null.");
        }

        // GET: NHC256KhachHang/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NHC256KhachHang == null)
            {
                return NotFound();
            }

            var nHC256KhachHang = await _context.NHC256KhachHang
                .FirstOrDefaultAsync(m => m.NHC256KhachHangID == id);
            if (nHC256KhachHang == null)
            {
                return NotFound();
            }

            return View(nHC256KhachHang);
        }

        // GET: NHC256KhachHang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NHC256KhachHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NHC256KhachHangID,NHC256NameKhachHang,NHC256Address")] NHC256KhachHang nHC256KhachHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nHC256KhachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nHC256KhachHang);
        }

        // GET: NHC256KhachHang/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NHC256KhachHang == null)
            {
                return NotFound();
            }

            var nHC256KhachHang = await _context.NHC256KhachHang.FindAsync(id);
            if (nHC256KhachHang == null)
            {
                return NotFound();
            }
            return View(nHC256KhachHang);
        }

        // POST: NHC256KhachHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NHC256KhachHangID,NHC256NameKhachHang,NHC256Address")] NHC256KhachHang nHC256KhachHang)
        {
            if (id != nHC256KhachHang.NHC256KhachHangID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nHC256KhachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NHC256KhachHangExists(nHC256KhachHang.NHC256KhachHangID))
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
            return View(nHC256KhachHang);
        }

        // GET: NHC256KhachHang/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NHC256KhachHang == null)
            {
                return NotFound();
            }

            var nHC256KhachHang = await _context.NHC256KhachHang
                .FirstOrDefaultAsync(m => m.NHC256KhachHangID == id);
            if (nHC256KhachHang == null)
            {
                return NotFound();
            }

            return View(nHC256KhachHang);
        }

        // POST: NHC256KhachHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NHC256KhachHang == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NHC256KhachHang'  is null.");
            }
            var nHC256KhachHang = await _context.NHC256KhachHang.FindAsync(id);
            if (nHC256KhachHang != null)
            {
                _context.NHC256KhachHang.Remove(nHC256KhachHang);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NHC256KhachHangExists(int id)
        {
          return (_context.NHC256KhachHang?.Any(e => e.NHC256KhachHangID == id)).GetValueOrDefault();
        }
    }
}
