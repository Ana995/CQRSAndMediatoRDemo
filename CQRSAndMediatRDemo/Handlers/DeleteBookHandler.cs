using CQRSAndMediatRDemo.Commands;
using CQRSAndMediatRDemo.Repositories;
using MediatR;

namespace CQRSAndMediatRDemo.Handlers
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var bookDetails = await _bookRepository.GetBookByIdAsync(request.Id);
            if(bookDetails == null)
            {
                return default;
            }
            return await _bookRepository.DeleteBookAsync(bookDetails.Id);
        }
    }
}
