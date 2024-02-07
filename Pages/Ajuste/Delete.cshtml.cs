using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aspnetcoreapp;
using aspnetcoreapp.Entidades;

namespace aspnetcoreapp.Pages.Ajuste
{
    public class DeleteModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public DeleteModel(aspnetcoreapp.ApplicationDbContext context)
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

            var ajustes = await _context.Ajustes.FirstOrDefaultAsync(m => m.Id == id);

            if (ajustes == null)
            {
                return NotFound();
            }
            else 
            {
                Ajustes = ajustes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Ajustes == null)
            {
                return NotFound();
            }
            var ajustes = await _context.Ajustes.FindAsync(id);

            if (ajustes != null)
            {
                Ajustes = ajustes;
                _context.Ajustes.Remove(Ajustes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
