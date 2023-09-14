using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookProjectWebAPI.Entities.Configs
{
	public class BookConfig : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.Property(b => b.Title).IsRequired();
			builder.Property(b => b.PublishDate).HasColumnType("date");
		}
	}
}
