using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSport.Data;
using RazorSport.Models;

namespace RazorSport.Pages.Atleten
{
    public class IndexModel : PageModel
    {
        private readonly RazorSport.Data.RazorSportContext _context;

        public IndexModel(RazorSport.Data.RazorSportContext context)
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
