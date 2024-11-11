using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoBiblioteca.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        #region Book
        //GET api/book?search=crm
        [HttpGet]
        public IActionResult GetAllBooks(string search = "")
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByBookId(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostBook()
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
        #endregion
    }
}
