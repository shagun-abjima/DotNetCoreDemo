using BookStoreApi.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int bookId);
        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdateBookAsync(int bookId, BookModel bookModel);
        Task UpdateBookPatchAsync(int bookId ,JsonPatchDocument bookModel);
        Task<int> DeleteBookAsync(int bookId);
    }
}
