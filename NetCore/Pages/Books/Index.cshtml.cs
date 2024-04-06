using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly NetCoreContext _db;

        public IndexModel(NetCoreContext db)
        {
            _db = db;
        }

        public IEnumerable<Models.Book> Books { get; set; }

        public async Task OnGetAsync()
        {
            Books = await _db.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var book = await _db.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.Book.Remove(book);
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
