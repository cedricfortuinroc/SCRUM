using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSport.Data;
using RazorSport.Models;

namespace RazorSport.Pages.Atleten
{
    public class CreateModel : PageModel
    {
        private readonly RazorSport.Data.RazorSportContext _context;

        public CreateModel(RazorSport.Data.RazorSportContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Atleet Atleet { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Atleet.Add(Atleet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
