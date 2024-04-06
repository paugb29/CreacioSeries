using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetCore.Data;
using NetCore.Models;


namespace NetCore.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly NetCoreContext _db;

        public EditModel(NetCoreContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookFromDb = await _db.Book.FindAsync(Book.Id);
                bookFromDb.Nom = Book.Nom;
                bookFromDb.ISBN = Book.ISBN;
                bookFromDb.Autor = Book.Autor;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}