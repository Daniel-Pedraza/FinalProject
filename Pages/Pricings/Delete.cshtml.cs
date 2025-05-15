using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages_Pricings
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Models.AppDbContext _context;

        public DeleteModel(FinalProject.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pricing Pricing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricing = await _context.Pricings.FirstOrDefaultAsync(m => m.PricingID == id);

            if (pricing is not null)
            {
                Pricing = pricing;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pricing = await _context.Pricings.FindAsync(id);
            if (pricing != null)
            {
                Pricing = pricing;
                _context.Pricings.Remove(Pricing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
