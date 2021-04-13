using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using RazorSport.Data;
using RazorSport.Models;

namespace RazorSport.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly RazorSportContext _context;

        public IndexModel(ILogger<IndexModel> logger, RazorSportContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Atleet> Atleten { get; set; }
        
        public async Task OnGetAsync()
        {
            Atleten = await _context.Atleet.ToListAsync();
        }
    }
}
