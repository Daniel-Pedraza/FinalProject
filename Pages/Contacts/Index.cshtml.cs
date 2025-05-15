using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages_Contacts
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.AppDbContext _context;

        public IndexModel(FinalProject.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Contact = await _context.Contacts
                .Include(c => c.Member)
                .Include(c => c.Pricing).ToListAsync();
        }
    }
}
