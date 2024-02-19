using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using NetCore.Models;

namespace NetCore.Pages.Plataformes
{
    public class DetailsModel : PageModel
    {
        private readonly NetCore.Data.NetCoreContext _context;

        public DetailsModel(NetCore.Data.NetCoreContext context)
        {
            _context = context;
        }

      public Plataforma Plataforma { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Plataforma == null)
            {
                return NotFound();
            }

            var plataforma = await _context.Plataforma.FirstOrDefaultAsync(m => m.Id == id);
            if (plataforma == null)
            {
                return NotFound();
            }
            else 
            {
                Plataforma = plataforma;
            }
            return Page();
        }
    }
}
