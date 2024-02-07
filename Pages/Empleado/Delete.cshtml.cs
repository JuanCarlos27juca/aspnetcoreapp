using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aspnetcoreapp;
using aspnetcoreapp.Entidades;
using Microsoft.AspNetCore.Authorization;

namespace aspnetcoreapp.Pages.Empleado
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public DeleteModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Empleados Empleados { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Empleados == null)
            {
                return NotFound();
            }

            var empleados = await _context.Empleados.FirstOrDefaultAsync(m => m.Contrasenia == id);

            if (empleados == null)
            {
                return NotFound();
            }
            else 
            {
                Empleados = empleados;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Empleados == null)
            {
                return NotFound();
            }
            var empleados = await _context.Empleados.FindAsync(id);

            if (empleados != null)
            {
                Empleados = empleados;
                _context.Empleados.Remove(Empleados);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
