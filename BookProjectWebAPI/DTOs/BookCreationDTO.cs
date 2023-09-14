using System.ComponentModel.DataAnnotations;

namespace BookProjectWebAPI.DTOs
{
	public class BookCreationDTO
	{
		[Required]
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public int PageCount { get; set; }
		public string Excerpt { get; set; } = null!;
		public DateTime PublishDate { get; set; }
	}
}
