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

    public class IndexModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public IndexModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }
        public List<DateTime> Mov_empleados = new List<DateTime>();
        public IList<Movimientos> Movimientos { get;set; } = default!;
        public IList<Empleados> Empleados { get; set; } = default!;
        public IList<Ajustes> Ajustes { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movimientos != null)
            {
                Movimientos = await _context.Movimientos.ToListAsync();
            }
            if (_context.Empleados != null)
            {
                Empleados = await _context.Empleados.ToListAsync();
            }
            if (_context.Ajustes != null)
            {
                Ajustes = await _context.Ajustes.ToListAsync();
            }
        }
    }
}
