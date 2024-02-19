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

namespace NetCore.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly NetCore.Data.NetCoreContext _context;

        public IndexModel(NetCore.Data.NetCoreContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        [BindProperty(SupportsGet = true)]

        public string SearchString { get; set; }

        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Title { get; set; }
        


        public async Task OnGetAsync()
        {
            var clients = from m in _context.Client
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
               clients = clients.Where(s => s.Nom.Contains(SearchString));
            }
            Client = await clients.ToListAsync();
        }
    }
}
