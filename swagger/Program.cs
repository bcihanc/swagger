using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services
  .AddControllers();
  // .AddJsonOptions(options =>
  //   options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
  options.EnableAnnotations();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();

public class BookBodyRequest
{
  [Required] public required string Id { get; set; }

  public string Name { get; set; }

  [DefaultValue(true)] public bool publish { get; set; }

  [JsonConverter(typeof(JsonStringEnumConverter))]
  public BookGenre BookGenre { get; set; }
}

public class BookResponse
{
  [Required] public required string Title { get; set; }
  public string? Author { get; set; }

  public BookGenre BookGenre { get; set; }
}

public enum BookGenre
{
  thriller = 1,
  horror = 2
}