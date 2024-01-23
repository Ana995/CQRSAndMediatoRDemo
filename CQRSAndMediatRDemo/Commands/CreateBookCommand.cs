using CQRSAndMediatRDemo.Models;
using MediatR;

namespace CQRSAndMediatRDemo.Commands
{
    public class CreateBookCommand : IRequest<Book>
    {
      
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublicationYear { get; set; }
        public string Genre { get; set; }
        // Other properties

        public CreateBookCommand(string title, string author, string publicationYear, string genre)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Genre = genre;
        }

    }
}
