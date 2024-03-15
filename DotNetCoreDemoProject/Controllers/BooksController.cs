﻿using BookStoreApi.Model;
using BookStoreApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository) 
        {
            _bookRepository = bookRepository;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books=await _bookRepository.GetAllBooksAsync();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute]int id)
        {
            var book = await _bookRepository.GetBookByIdAsync(id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost("")]
        public async Task<IActionResult> AddNewBook([FromBody] BookModel bookModel)
        {
            var id = await _bookRepository.AddBookAsync(bookModel);
            return CreatedAtAction(nameof(GetBookById), new { id=id, Controller="books" }, id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromBody] BookModel bookModel, [FromRoute]int id)
        { 
            await _bookRepository.UpdateBookAsync(id ,bookModel);
            return Ok(id);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookPatch([FromBody] JsonPatchDocument bookModel, [FromRoute] int id)
        {
            await _bookRepository.UpdateBookPatchAsync(id, bookModel);
            return Ok(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _bookRepository.DeleteBookAsync(id);
            return Ok(id);
        }
    }
}
