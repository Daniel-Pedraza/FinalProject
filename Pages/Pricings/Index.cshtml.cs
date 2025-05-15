using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Pricings;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<Pricing> PricingList { get; set; } = default!;

    public async Task OnGetAsync()
    {
        PricingList = await _context.Pricings.ToListAsync();
    }
}
