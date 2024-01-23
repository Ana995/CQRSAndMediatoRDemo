using CQRSAndMediatRDemo.Models;
using MediatR;

namespace CQRSAndMediatRDemo.Queries
{
    public class GetBookByIdQuery: IRequest<Book>
    {
        public int Id { get; set; }
    }
}
