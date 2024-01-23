using CQRSAndMediatRDemo.Models;

namespace CQRSAndMediatRDemo.Repositories
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetBooksListAsync();
        public Task<Book> GetBookByIdAsync(int Id);
        public Task<Book> AddBookAsync(Book bookDetails);
        public Task<int> UpdateBookAsync(Book bookDetails);
        public Task<int> DeleteBookAsync(int Id);
    }
}
