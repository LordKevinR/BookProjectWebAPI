using BookProjectWebAPI.DTOs;
using BookProjectWebAPI.Entities;
using BookProjectWebAPI.Interfaces;

namespace BookProjectWebAPI.Services
{
	public class BookService : IBookService
	{
		private readonly IBookRepository bookRepository;

		public BookService(IBookRepository bookRepository)
		{
			this.bookRepository = bookRepository;
		}


		public async Task<IEnumerable<Book>> GetAllBooks()
		{
			return await bookRepository.GetAllBooks();
		}


		public async Task<Book> GetById(int id)
		{
			return await bookRepository.GetById(id);
		}


		public async Task PostNewBook(BookCreationDTO bookCreationDTO)
		{
			await bookRepository.PostNewBook(bookCreationDTO);
		}


		public async Task UpdateABook(int id, BookCreationDTO bookCreationDTO)
		{
			await bookRepository.UpdateABook(id, bookCreationDTO);
		}


		public async Task DeleteABook(int id)
		{
			await bookRepository.DeleteABook(id);
		}


	}
}
