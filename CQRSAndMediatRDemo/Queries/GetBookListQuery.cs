using CQRSAndMediatRDemo.Models;
using MediatR;

namespace CQRSAndMediatRDemo.Queries
{
    public class GetBookListQuery: IRequest<List<Book>>
    {
    }
}
