using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.netMVCCRUD.Models;

namespace Asp.netMVCCRUD.Controllers
{
    public class ImonesController : Controller
    {
        private readonly ImoneContext _context;

        public ImonesController(ImoneContext context)
        {
            _context = context;
        }

        // GET: Imones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Imones.ToListAsync());
        }

     
        

        // GET: Imones/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if(id==0)
                return View(new Imone());
            else
                return View(_context.Imones.Find(id));
        }

        // POST: Imones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Pavadinimas,ElPastas,BlogasElPastas,TelNr,Apskritis,VMVT,KitaInfo,AktualiVeikla,ImonesKodas")] Imone imone)
        {
            if (ModelState.IsValid)
            {
                if(imone.Id == 0)
                    _context.Add(imone);
                else
                    _context.Update(imone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imone);
        }

        // GET: Imones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imone = await _context.Imones.FindAsync(id);
            if (imone == null)
            {
                return NotFound();
            }
            return View(imone);
        }

        // POST: Imones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pavadinimas,ElPastas,BlogasElPastas,TelNr,Apskritis,VMVT,KitaInfo,AktualiVeikla,ImonesKodas")] Imone imone)
        {
            if (id != imone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImoneExists(imone.Id))
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
            return View(imone);
        }

        // GET: Imones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            var imone = await _context.Imones.FindAsync(id);
            _context.Imones.Remove(imone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        // POST: Imones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imone = await _context.Imones.FindAsync(id);
            _context.Imones.Remove(imone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImoneExists(int id)
        {
            return _context.Imones.Any(e => e.Id == id);
        }
    }
}
