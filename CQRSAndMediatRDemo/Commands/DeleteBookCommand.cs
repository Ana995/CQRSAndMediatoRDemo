using MediatR;

namespace CQRSAndMediatRDemo.Commands
{
    public class DeleteBookCommand: IRequest<int>
    {
        public int Id { get; set; }
    }
}
