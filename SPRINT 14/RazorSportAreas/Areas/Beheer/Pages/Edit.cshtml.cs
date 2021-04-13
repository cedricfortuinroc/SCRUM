using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorSportAreas.Data;
using RazorSportAreas.Models;

namespace RazorSportAreas.Areas.Beheer.Pages
{
    public class EditModel : PageModel
    {
        private readonly RazorSportAreas.Data.RazorSportAreasContext _context;

        public EditModel(RazorSportAreas.Data.RazorSportAreasContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Atleet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AtleetExists(Atleet.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AtleetExists(int id)
        {
            return _context.Atleet.Any(e => e.ID == id);
        }
    }
}
