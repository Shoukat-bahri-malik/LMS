using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LMS.DataLayer;
using LMS.Models.Domain;

namespace LMS.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly LMS.DataLayer.LMSDbContext _context;

        public List<SelectListItem> categories { get; set; }
        public CreateModel(LMS.DataLayer.LMSDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            categories = _context.Categories.Select(i =>new SelectListItem()
            {
                Text = i.Name,
                Value =i.CategoryId.ToString(),
            }).ToList();


            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Books == null || Book == null)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
