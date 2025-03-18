using CsvHelper;
using CsvHelper.Configuration;
using EcoEnergyBBDD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace EcoEnergyBBDD.Pages
{
    public class EnergeticIndicatorsModel : PageModel
    {
        // Flags to indicate file existence and records availability
        public bool FileExists { get; set; }
        public bool FileHasRecords { get; set; }

        // Lists to store energy indicators and calculated averages
        public List<EnergyIndicator> EnergyIndicatorList { get; set; } = new List<EnergyIndicator>();
        public List<EnergyIndicator> ElectricityDemand { get; set; } = new List<EnergyIndicator>();

        public void OnGet()
        {
            Z
        }
    }
}
