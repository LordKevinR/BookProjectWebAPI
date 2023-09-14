namespace BookProjectWebAPI.Entities
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public int PageCount { get; set; }
		public string Excerpt { get; set; } = null!;
		public DateTime PublishDate { get; set; }
	}
}
