using CQRSAndMediatRDemo.Commands;
using CQRSAndMediatRDemo.Repositories;
using MediatR;

namespace CQRSAndMediatRDemo.Handlers
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;

        public UpdateBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var bookDetails = await _bookRepository.GetBookByIdAsync(request.Id);
            if (bookDetails == null)
            {
                return default;
            }
            bookDetails.Author = request.Author;
            bookDetails.Title = request.Title; 
            bookDetails.Genre = request.Genre; 
            bookDetails.PublicationYear = request.PublicationYear; 

            return await _bookRepository.UpdateBookAsync(bookDetails); 
        }
    }
}
