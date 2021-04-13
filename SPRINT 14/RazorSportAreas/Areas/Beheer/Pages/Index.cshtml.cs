using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSportAreas.Data;
using RazorSportAreas.Models;

namespace RazorSportAreas.Areas.Beheer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorSportAreas.Data.RazorSportAreasContext _context;

        public IndexModel(RazorSportAreas.Data.RazorSportAreasContext context)
        {
            _context = context;
        }

        public IList<Atleet> Atleet { get;set; }

        public async Task OnGetAsync()
        {
            Atleet = await _context.Atleet.ToListAsync();
        }
    }
}
