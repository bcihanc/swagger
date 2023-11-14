using Microsoft.AspNetCore.Mvc;
using swagger.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace swagger.Controllers
{
  
  [Route("api/library")]
  [ApiController]
  public class BookController : ControllerBase
  {
    
    [HttpPost]
    [Route("book")]
    [SwaggerResponse(201, "The book was created")]
    [SwaggerOperation(
      Summary = "Creates a new book",
      Description = "Requires admin privileges",
      Tags = new[] { "admin" }
    )]
    public IActionResult CreateBook(BookBodyRequest request)
    {
      return Ok();
    }
    
    [HttpGet]
    [Route("book/{id}")]
    [SwaggerOperation(Tags = new[] { "admin", "user" })]
    [SwaggerResponse(201, "", typeof(BookResponse))]
    public IActionResult GetBook(String id)
    {
      return Ok();
    }
  
  
    [HttpGet]
    [Route("book")]
    [SwaggerOperation(Tags = new[] { "admin", "user" })]
    [SwaggerResponse(201, "get the books by filters", typeof(List<BookResponse>))]
    public IActionResult GetExamQuestions(String authorId)
    {
      return Ok();
    }
  }
}
