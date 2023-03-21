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
    public class DetailsModelStud : PageModel
    {
        private readonly Data.Context _contextStud;

        public DetailsModelStud(Data.Context context)
        {
            _contextStud = context;
        }

        public IList<Mark> MarkStud { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_contextStud.Marks != null)
            {
                MarkStud = await _contextStud.Marks.ToListAsync();
            }
        }
    }
}
