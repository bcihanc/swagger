using System.ComponentModel.DataAnnotations;

namespace swagger.DTOs
{
  public class BookResponse
  {
    [Required] public required string Title { get; set; }
    public string? Author { get; set; }

    public BookGenre BookGenre { get; set; }
  }
}
