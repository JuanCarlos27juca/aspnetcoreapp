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

namespace aspnetcoreapp.Pages.Movimiento
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
        public Movimientos Movimientos { get; set; } = default!;
        public IList<Empleados> Empleados { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movimientos == null)
            {
                return NotFound();
            }

            var movimientos = await _context.Movimientos.FirstOrDefaultAsync(m => m.Id == id);

            if (movimientos == null)
            {
                return NotFound();
            }
            else
            {
                Movimientos = movimientos;
            }

            if (_context.Empleados != null)
            {
                Empleados = await _context.Empleados.ToListAsync();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Movimientos == null)
            {
                return NotFound();
            }
            var movimientos = await _context.Movimientos.FindAsync(id);

            if (movimientos != null)
            {
                Movimientos = movimientos;
                _context.Movimientos.Remove(Movimientos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
