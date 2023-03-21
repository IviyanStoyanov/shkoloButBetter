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
    public class DetailsModelStudent : PageModel
    {
        private readonly Data.Context _contextStudent;

        public DetailsModelStudent(Data.Context context)
        {
            _contextStudent = context;
        }

      public Mark MarkStudents { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _contextStudent.Marks == null)
            {
                return NotFound();
            }

            var mark = await _contextStudent.Marks.FirstOrDefaultAsync(m => m.Id == id);
            if (mark == null)
            {
                return NotFound();
            }
            else 
            {
                MarkStudents = mark;
            }
            return Page();
        }
    }
}
