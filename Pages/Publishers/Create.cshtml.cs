using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Marian_Cristina_lab02.Data;
using Marian_Cristina_lab02.Models;

namespace Marian_Cristina_lab02.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Marian_Cristina_lab02.Data.Marian_Cristina_lab02Context _context;

        public CreateModel(Marian_Cristina_lab02.Data.Marian_Cristina_lab02Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
