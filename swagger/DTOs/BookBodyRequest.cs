using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace swagger.DTOs
{
  public class BookBodyRequest
  {
    [Required] public required string Id { get; set; }

    public string Name { get; set; }

    [DefaultValue(true)] public bool publish { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public BookGenre BookGenre { get; set; }
  }
}
