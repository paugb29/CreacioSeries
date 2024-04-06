using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using NetCore.Models;
using System.Threading.Tasks;

namespace NetCore.Pages
{
    public class UpsertModel : PageModel
    {
        private readonly NetCoreContext _context;

        public UpsertModel(NetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Book = new Book();

            if (id == null)
            {
                return Page();
            }

            Book = await _context.Book.FirstOrDefaultAsync(u => u.Id == id);

            if (Book == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Book.Id == 0)
            {
                _context.Book.Add(Book);
            }
            else
            {
                _context.Book.Update(Book);
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
