using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LMS.DataLayer;
using LMS.Models.Domain;

namespace LMS.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly LMS.DataLayer.LMSDbContext _context;

        public IndexModel(LMS.DataLayer.LMSDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Category = await _context.Categories.ToListAsync();
            }
        }
    }
}
