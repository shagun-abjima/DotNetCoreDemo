using BookStoreApi.Data;
using BookStoreApi.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context) 
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBooksAsync() 
        {
            var records = await _context.Book.Select(x=> new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            }).ToListAsync();

            return records;
        }
        public async Task<BookModel> GetBookByIdAsync(int bookId)
        {
            var records = await _context.Book.Where(x => x.Id == bookId).Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description
            }).FirstOrDefaultAsync();

            return records;
        }

        public async Task<int> AddBookAsync(BookModel bookModel)
        {
            var book = new Book()
            {
                Title = bookModel.Title,
                Description= bookModel.Description  
            };
            _context.Book.Add(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }
        public async Task UpdateBookAsync(int bookId, BookModel bookModel)
        {
            var book = new Book()
            {
                Id = bookId,
                Title = bookModel.Title,
                Description = bookModel.Description
            };
            _context.Book.Update(book);
            await _context.SaveChangesAsync();

        }
        public async Task UpdateBookPatchAsync(int bookId, JsonPatchDocument bookModel)
        {
           var book = await _context.Book.FindAsync(bookId);
            if (book != null)
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<int> DeleteBookAsync(int bookId)
        {
            var book = new Book() { Id = bookId };
            
            _context.Book.Remove(book);
            await _context.SaveChangesAsync();
            return book.Id;
        }
    }
}
