using BookProjectWebAPI.DTOs;
using BookProjectWebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookProjectWebAPI.Controllers
{
	[ApiController]
	[Route("api/books")]
	public class BooksController : ControllerBase
	{
		private readonly IBookService bookService;

		public BooksController(IBookService bookService)
		{
			this.bookService = bookService;
		}

		[HttpGet]
		public async Task<ActionResult> Get()
		{
			var books = await bookService.GetAllBooks();
			return Ok(books);
		}

		[HttpGet("id:int")]
		public async Task<ActionResult> GetById(int id)
		{
			var book = await bookService.GetById(id);

			if (book is null)
			{
				return NotFound();
			}

			return Ok(book);
		}

		[HttpPost]
		public async Task<ActionResult> Post(BookCreationDTO bookCreationDTO)
		{
			await bookService.PostNewBook(bookCreationDTO);
			return Ok(bookCreationDTO);
		}


		[HttpPut("id:int")]
		public async Task<ActionResult> Put(int id, BookCreationDTO bookCreationDTO)
		{
			await bookService.UpdateABook(id, bookCreationDTO);
			return Ok(bookCreationDTO);
		}


		[HttpDelete("id:int")]
		public async Task<ActionResult> Delete(int id)
		{
			await bookService.DeleteABook(id);
			return NoContent();
		}
	}
}
