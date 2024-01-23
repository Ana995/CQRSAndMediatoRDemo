using CQRSAndMediatRDemo.Models;
using CQRSAndMediatRDemo.Queries;
using CQRSAndMediatRDemo.Repositories;
using MediatR;

namespace CQRSAndMediatRDemo.Handlers
{
    public class GetBookListHandler : IRequestHandler<GetBookListQuery, List<Book>>
    {
        private readonly IBookRepository _bookRepository;

        public GetBookListHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<Book>> Handle(GetBookListQuery request, CancellationToken cancellationToken)
        {
            return await _bookRepository.GetBooksListAsync();
        }
    }
}
