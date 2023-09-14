using BookProjectWebAPI.DTOs;
using BookProjectWebAPI.Entities;
using BookProjectWebAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookProjectWebAPI.Services
{
    public class BookRepository : IBookRepository
	{
		private readonly ApplicationDbContext context;

		public BookRepository(ApplicationDbContext context)
        {
			this.context = context;
		}

		public async Task<IEnumerable<Book>> GetAllBooks()
		{
			return await context.Books.ToListAsync();
		}

		public async Task<Book> GetById(int id)
		{
			return await context.Books.FirstOrDefaultAsync(b => b.Id == id);
		}


		public async Task PostNewBook(BookCreationDTO bookCreationDTO)
		{
			var book = new Book
			{
				Title = bookCreationDTO.Title,
				Description = bookCreationDTO.Description,
				PageCount = bookCreationDTO.PageCount,
				Excerpt = bookCreationDTO.Excerpt,
				PublishDate = bookCreationDTO.PublishDate,
			};

			context.Add(book);
			await context.SaveChangesAsync();
		}

		public async Task UpdateABook(int id, BookCreationDTO bookCreationDTO)
		{
			var bookExist = await context.Books.FindAsync(id);

			if (bookExist == null)
			{
				return;
			}

			bookExist.Title = bookCreationDTO.Title;
			bookExist.Description = bookCreationDTO.Description;
			bookExist.PageCount = bookCreationDTO.PageCount;
			bookExist.Excerpt = bookCreationDTO.Excerpt;
			bookExist.PublishDate = bookCreationDTO.PublishDate;

			await context.SaveChangesAsync();
		}

		public async Task DeleteABook(int id)
		{
			var book = await context.Books.Where(b => b.Id == id).ExecuteDeleteAsync();
		}



    }
}
