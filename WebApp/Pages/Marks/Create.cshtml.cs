using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Data;
using Data.Model;

namespace WebApp.Pages.Marks
{
    public class CreateModel : PageModel
    {
        private readonly Data.Context _context;

        public CreateModel(Data.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Mark Mark { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Marks == null || Mark == null)
            {
                return Page();
            }

            _context.Marks.Add(Mark);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
