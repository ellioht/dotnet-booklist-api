using System;
using Microsoft.AspNetCore.Mvc;
using Booklist.Models;
using Booklist.Services;

namespace Booklist.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooklistController : ControllerBase
{
  private readonly BooklistService _booklistService;

  public BooklistController(BooklistService booklistService)
  {
    _booklistService = booklistService;
  }

  [HttpGet]
  public ActionResult<List<Book>> Get()
  {
    return _booklistService.Get();
  }
}
