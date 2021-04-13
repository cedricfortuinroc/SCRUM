using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSportAreas.Data;
using RazorSportAreas.Models;

namespace RazorSportAreas.Areas.Beheer.Pages
{
    public class CreateModel : PageModel
    {
        private readonly RazorSportAreas.Data.RazorSportAreasContext _context;

        public CreateModel(RazorSportAreas.Data.RazorSportAreasContext context)
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
