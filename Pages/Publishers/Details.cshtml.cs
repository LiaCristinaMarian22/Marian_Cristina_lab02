using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marian_Cristina_lab02.Data;
using Marian_Cristina_lab02.Models;

namespace Marian_Cristina_lab02.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Marian_Cristina_lab02.Data.Marian_Cristina_lab02Context _context;

        public DetailsModel(Marian_Cristina_lab02.Data.Marian_Cristina_lab02Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
