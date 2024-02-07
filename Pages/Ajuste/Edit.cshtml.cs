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

namespace aspnetcoreapp.Pages.Ajuste
{
    public class EditModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public EditModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ajustes Ajustes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ajustes == null)
            {
                return NotFound();
            }

            var ajustes =  await _context.Ajustes.FirstOrDefaultAsync(m => m.Id == id);
            if (ajustes == null)
            {
                return NotFound();
            }
            Ajustes = ajustes;
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

            _context.Attach(Ajustes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AjustesExists(Ajustes.Id))
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

        private bool AjustesExists(int id)
        {
          return (_context.Ajustes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
