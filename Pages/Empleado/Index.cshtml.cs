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
    [Authorize(Policy = "DebeSerAdministrador")]
    public class IndexModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public IndexModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Empleados> Empleados { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Empleados != null)
            {
                Empleados = await _context.Empleados.ToListAsync();
            }
        }
    }
}
