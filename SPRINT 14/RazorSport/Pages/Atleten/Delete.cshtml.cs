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
    public class DeleteModel : PageModel
    {
        private readonly RazorSport.Data.RazorSportContext _context;

        public DeleteModel(RazorSport.Data.RazorSportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Atleet Atleet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Atleet = await _context.Atleet.FirstOrDefaultAsync(m => m.ID == id);

            if (Atleet == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Atleet = await _context.Atleet.FindAsync(id);

            if (Atleet != null)
            {
                _context.Atleet.Remove(Atleet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
