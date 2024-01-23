using CQRSAndMediatRDemo.Data;
using CQRSAndMediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndMediatRDemo.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DbContextClass _dbContext;

        public BookRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Book> AddBookAsync(Book bookDetails)
        {
            var result = _dbContext.Books.Add(bookDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteBookAsync(int Id)
        {
            var filteredData = _dbContext.Books.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Books.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Book> GetBookByIdAsync(int Id)
        {
            return await _dbContext.Books.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    
        public async Task<List<Book>> GetBooksListAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<int> UpdateBookAsync(Book bookDetails)
        {
            _dbContext.Books.Update(bookDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
