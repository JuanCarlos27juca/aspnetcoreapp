using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using aspnetcoreapp.Entidades;//
using Microsoft.EntityFrameworkCore;//

namespace aspnetcoreapp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly aspnetcoreapp.ApplicationDbContext _context;//

    public IndexModel(ILogger<IndexModel> logger, aspnetcoreapp.ApplicationDbContext context)//
    {
        _logger = logger;
        _context = context;//
    }


    public IList<Empleados> Empleados { get; set; } = default!;//
    public IList<Movimientos> Movimientos { get; set; } = default!;//

    public string texto_pasado { get; set; } = null!;
    public string Rol { get; set; } = null!;
    public List<DateTime> mpe { get; set; } = null!;
    public List<string> dmpe { get; set; } = null!;
    public List<string> vista_dmpe = new List<string>();
    public List<string> vista_dmpe_dds = new List<string>();
    public List<string> descripciones = new List<string>() { "Entrada", "Comida Out", "Comida In", "10 Out", "10 In", "Salida" };

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPostAsync(Usuario usuario)
    {
        if (!ModelState.IsValid) return Page();

        if (_context.Empleados != null)//
        {//
            Empleados = await _context.Empleados.ToListAsync();//
        }//
        if (_context.Movimientos != null)//
        {//
            Movimientos = await _context.Movimientos.ToListAsync();//
        }//
        if (usuario.psw == "9327501")
        {
            Rol = "Administrador";
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "admin"),
                new Claim(ClaimTypes.Email, "admin@mywebsite.com"),
                new Claim("Usuario", "Administrador")
            };

            var identity = new ClaimsIdentity(claims, "MyCookieAuth");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
            this.texto_pasado = string.Format("{0}", "Access granted");
            return RedirectToPage("/Index");
        }
        foreach (var item in Empleados)
        {
            if (item.Contrasenia == usuario.psw)
            {
                Rol = "Empleado";
                this.texto_pasado = string.Format("{0}", item.Nombre);
                this.mpe = Movimientos.Where(x => x.Contrasenia == usuario.psw).OrderBy(y => y.DiaHora).Select(w => w.DiaHora).ToList();
                this.dmpe = Movimientos.Where(x => x.Contrasenia == usuario.psw).OrderBy(y => y.DiaHora).Select(w => w.Movimiento).ToList();
            }
        }
        if (Rol == "Empleado")
        {
            int cuenta4 = 0;
            for (int cuenta1 = 0; cuenta1 < dmpe.Count; cuenta1++)
            {
                //bool coinciden = false;
                for (int cuenta2 = cuenta4; cuenta2 < descripciones.Count; cuenta2++)
                {
                    if (dmpe[cuenta1] == descripciones[cuenta2]/* && coinciden == false// && this.vista_dmpe.Count < 6*/)
                    {
                        //coinciden = true;
                        string dia_semana = mpe[cuenta1].ToString("dddddddd");
                        string hora_dia = mpe[cuenta1].ToString("hh:mm tt");
                        this.vista_dmpe.Add(hora_dia);
                        this.vista_dmpe_dds.Add(dia_semana);
                        cuenta4 = cuenta2 + 1;
                        break;
                    }
                    else
                    {
                        /*if (this.vista_dmpe.Count < 6)
                        {*/
                        this.vista_dmpe.Add("-");
                        this.vista_dmpe_dds.Add("-");
                        //}
                    }
                }
                if (this.vista_dmpe.Count % 6 == 0)
                {
                    cuenta4 = 0;
                }
            }
            for (int cuenta3 = this.vista_dmpe.Count; cuenta3 < 30/*descripciones.Count*/; cuenta3++)
            {
                this.vista_dmpe.Add("-");
            }
        }
        if (this.vista_dmpe.Count > 0)
        {

        }
        return Page();
        /*else
        {
            this.texto_pasado = "";
        }
        */
    }
}
