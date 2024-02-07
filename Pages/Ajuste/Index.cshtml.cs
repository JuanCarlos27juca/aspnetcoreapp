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
    public class IndexModel : PageModel
    {
        private readonly aspnetcoreapp.ApplicationDbContext _context;

        public IndexModel(aspnetcoreapp.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Ajustes> Ajustes { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ajustes != null)
            {
                Ajustes = await _context.Ajustes.ToListAsync();
            }
        }
    }
}
