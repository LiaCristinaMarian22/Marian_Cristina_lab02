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
    public class IndexModel : PageModel
    {
        private readonly Marian_Cristina_lab02.Data.Marian_Cristina_lab02Context _context;

        public IndexModel(Marian_Cristina_lab02.Data.Marian_Cristina_lab02Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
