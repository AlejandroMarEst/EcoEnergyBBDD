using EcoEnergyBBDD.Data;
using EcoEnergyBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace EcoEnergyBBDD.Pages
{
    // PageModel for inserting a new energy indicator
    public class InsertEnergyIndicatorModel : PageModel
    {
        [BindProperty]
        public EnergyIndicator? EnergyIndicator { get; set; }
        public IActionResult OnPost()
        {
            using var context = new ApplicationDbContext();

            context.EnergyIndicator.Add(EnergyIndicator);
            context.SaveChanges();

            return RedirectToPage("EnergeticIndicators");
        }
    }
}
