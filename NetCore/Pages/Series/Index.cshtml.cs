using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using NetCore.Models;

namespace NetCore.Pages.Series
{
    public class IndexModel : PageModel
    {
        private readonly NetCore.Data.NetCoreContext _context;

        public IndexModel(NetCore.Data.NetCoreContext context)
        {
            _context = context;
        }

        public IList<Serie> Serie { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]

        public string Title { get; set; }


        public async Task OnGetAsync()
        {
            var series = from m in _context.Serie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
               series = series.Where(s => s.Title.Contains(SearchString));
            }
            Serie = await series.ToListAsync();
        }
    }
}
