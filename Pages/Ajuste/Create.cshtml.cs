using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aspnetcoreapp;
using aspnetcoreapp.Entidades;

namespace aspnetcoreapp.Pages.Ajuste
{
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
        public Ajustes Ajustes { get; set; } = default!; 


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Ajustes == null || Ajustes == null)
            {
                return Page();
            }
                _context.Ajustes.Add(Ajustes);
                await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
