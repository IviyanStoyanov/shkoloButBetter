using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Model;

namespace WebApp.Pages.Marks
{
    public class IndexModel : PageModel
    {
        private readonly Data.Context _context;

        public IndexModel(Data.Context context)
        {
            _context = context;
        }

        public IList<Mark> Mark { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marks != null)
            {
                Mark = await _context.Marks.ToListAsync();
            }
        }
    }
}
