using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Contacts;

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;

    public CreateModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Contact Contact { get; set; } = default!;

    public SelectList MemberList { get; set; } = default!;
    public SelectList PricingList { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync()
    {
        MemberList = new SelectList(await _context.Members.ToListAsync(), "MemberID", "Name");
        PricingList = new SelectList(await _context.Pricings.ToListAsync(), "PricingID", "Description");

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        _context.Contacts.Add(Contact);
        await _context.SaveChangesAsync();

        return RedirectToPage("Index");
    }
}
