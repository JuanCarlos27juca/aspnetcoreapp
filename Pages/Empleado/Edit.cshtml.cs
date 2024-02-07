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

namespace aspnetcoreapp.Pages.Empleado
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
        public Empleados Empleados { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Empleados == null)
            {
                return NotFound();
            }

            var empleados =  await _context.Empleados.FirstOrDefaultAsync(m => m.Contrasenia == id);
            if (empleados == null)
            {
                return NotFound();
            }
            Empleados = empleados;
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

            _context.Attach(Empleados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadosExists(Empleados.Contrasenia))
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

        private bool EmpleadosExists(string id)
        {
          return (_context.Empleados?.Any(e => e.Contrasenia == id)).GetValueOrDefault();
        }
    }
}
