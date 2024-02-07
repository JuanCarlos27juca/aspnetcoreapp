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
    public class DetailsModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public DetailsModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
