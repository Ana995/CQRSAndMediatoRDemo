using MediatR;

namespace CQRSAndMediatRDemo.Commands
{
    public class UpdateBookCommand: IRequest<int>
    {
        public int Id { get; set; }    
        public string Title { get; set; }   
        public string Author { get; set; }
        public string PublicationYear { get; set; }
        public string Genre { get; set; }

        public UpdateBookCommand(int id, string title, string author, string publicationYear, string genre)
        {
            Id = id;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Genre = genre;
        }
    }

}
