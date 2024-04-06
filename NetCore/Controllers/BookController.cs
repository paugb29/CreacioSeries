using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCore.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly NetCoreContext _db;

        public BookController(NetCoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                Console.WriteLine("Recibida solicitud GET a la ruta /api/book");
                var books = await _db.Book.ToListAsync();
                return Json(new { data = books });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener datos de la base de datos: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Console.WriteLine($"Recibida solicitud DELETE a la ruta /api/book con ID: {id}");
                var bookFromDb = await _db.Book.FirstOrDefaultAsync(u => u.Id == id);
                if (bookFromDb == null)
                {
                    return Json(new { success = false, message = "Error while Deleting" });
                }
                _db.Book.Remove(bookFromDb);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "Delete successful" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar libro de la base de datos: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}