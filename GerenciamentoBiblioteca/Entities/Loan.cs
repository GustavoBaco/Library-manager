namespace GerenciamentoBiblioteca.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int idClient, User client, int idBook, Book book, DateTime loanDate) :base()
        {
            IdClient = idClient;
            Client = client;
            IdBook = idBook;
            Book = book;
            LoanDate = loanDate;
        }

        public int IdClient { get;private set; }
        public User Client { get; private set; }
        public int IdBook { get; private set; }
        public Book Book { get; private set; }
        public DateTime LoanDate { get; private set; }

    }
}
