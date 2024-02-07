using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace aspnetcoreapp.Pages
{
    public class Usuario
    {
        [BindProperty]
        public string psw { get; set; } = null!;
    }
}
