using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace swagger.Controllers
{
  
  [Route("api/darft")]
  [ApiController]
  public class BookController : ControllerBase
  {
    
    [HttpPost]
    [Route("book")]
    [SwaggerResponse(200, "The product was created", typeof(BookResponse))]
    [SwaggerResponse(400, "The product data is invalid")]
    [SwaggerOperation(
      Summary = "Creates a new product",
      Description = "Requires admin privileges",
      OperationId = "CreateProduct",
      Tags = new[] { "user" }
    )]
    public IActionResult GetBook(BookBodyRequest request)
    {
      return Ok();
    }
    
    // 'http://localhost:5091/api/darft/author/123'
    [HttpGet]
    [Route("author/{id}")]
    public IActionResult GetAuthor(String id)
    {
      return Ok();
    }
  
  
    // 'http://localhost:5091/api/darft/exam-questions?examId=123'
    [HttpGet]
    [Route("exam-questions")]
    public IActionResult GetExamQuestions(String examId)
    {
      return Ok();
    }
  }
}
