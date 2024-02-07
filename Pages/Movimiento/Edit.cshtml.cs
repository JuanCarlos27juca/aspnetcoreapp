using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aspnetcoreapp;
using aspnetcoreapp.Entidades;
using Microsoft.AspNetCore.Authorization;

namespace aspnetcoreapp.Pages.Movimiento
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public EditModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movimientos Movimientos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movimientos == null)
            {
                return NotFound();
            }

            var movimientos =  await _context.Movimientos.FirstOrDefaultAsync(m => m.Id == id);
            if (movimientos == null)
            {
                return NotFound();
            }
            Movimientos = movimientos;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Movimientos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimientosExists(Movimientos.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MovimientosExists(int id)
        {
          return (_context.Movimientos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
