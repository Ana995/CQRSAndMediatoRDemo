using CQRSAndMediatRDemo.Commands;
using CQRSAndMediatRDemo.Models;
using CQRSAndMediatRDemo.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSAndMediatRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator mediator;

        public BooksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Book>> GetBookListAsync()
        {
            var BookDetails = await mediator.Send(new GetBookListQuery());

            return BookDetails;
        }

        [HttpGet("BookId")]
        public async Task<Book> GetBookByIdAsync(int BookId)
        {
            var BookDetails = await mediator.Send(new GetBookByIdQuery() { Id = BookId });

            return BookDetails;
        }

        [HttpPost]
        public async Task<Book> AddBookAsync(Book BookDetails)
        {
            var BookDetail = await mediator.Send(new CreateBookCommand(
                BookDetails.Title,
                BookDetails.Author,
                BookDetails.PublicationYear,
                BookDetails.Genre));
            return BookDetail;
        }

        [HttpPut]
        public async Task<int> UpdateBookAsync(Book BookDetails)
        {
            var isBookDetailUpdated = await mediator.Send(new UpdateBookCommand(
               BookDetails.Id,
               BookDetails.Title,
               BookDetails.Author,
               BookDetails.PublicationYear,
               BookDetails.Genre));
            return isBookDetailUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteBookAsync(int Id)
        {
            return await mediator.Send(new DeleteBookCommand() { Id = Id });
        }
    }
}
