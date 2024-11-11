namespace GerenciamentoBiblioteca.Entities
{
    public class Book : BaseEntity
    {
        protected Book() { }
        public Book(string title, string author, string iSBN, int publicationYear) : base()
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            PublicationYear = publicationYear;
        }


        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public int PublicationYear { get; private set; }

        public void Update(string title, string author, string iSBN, int publicationYear)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            PublicationYear = publicationYear;
        }

    }
}
