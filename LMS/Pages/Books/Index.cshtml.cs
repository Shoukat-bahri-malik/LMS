using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LMS.DataLayer;
using LMS.Models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace LMS.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly LMS.DataLayer.LMSDbContext _context;

        public IndexModel(LMS.DataLayer.LMSDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Book = await _context.Books.ToListAsync();
                foreach (var book in Book)
                {
                    book.BookCategories = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == book.CategoryId);
                }
            }
        }
    }
}
