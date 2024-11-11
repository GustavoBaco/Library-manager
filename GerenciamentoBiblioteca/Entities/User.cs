namespace GerenciamentoBiblioteca.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate, bool active) : base()
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = active;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active {  get; private set; }
    }
}
