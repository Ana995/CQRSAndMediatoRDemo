using CQRSAndMediatRDemo.Commands;
using CQRSAndMediatRDemo.Models;
using CQRSAndMediatRDemo.Repositories;
using MediatR;

namespace CQRSAndMediatRDemo.Handlers
{
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, Book>

    {
        private readonly IBookRepository _bookRepository;

        public CreateBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var bookDetails = new Book()
            {
                Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                PublicationYear = request.PublicationYear,

            };
            
            return await _bookRepository.AddBookAsync(bookDetails); 
        }
    }
}
