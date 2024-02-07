using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aspnetcoreapp;
using aspnetcoreapp.Entidades;
using Microsoft.AspNetCore.Authorization;

namespace aspnetcoreapp.Pages.Movimiento
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public CreateModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movimientos Movimientos { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Movimientos == null || Movimientos == null)
            {
                return Page();
            }

            _context.Movimientos.Add(Movimientos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
