using BookProjectWebAPI.DTOs;
using BookProjectWebAPI.Entities;

namespace BookProjectWebAPI.Interfaces
{
	public interface IBookRepository
	{
		Task DeleteABook(int id);
		Task<IEnumerable<Book>> GetAllBooks();
		Task<Book> GetById(int id);
		Task PostNewBook(BookCreationDTO bookCreationDTO);
		Task UpdateABook(int id, BookCreationDTO bookCreationDTO);
	}
}
