namespace WebApplication1.Clasess
{
    public enum ContactStatus
    {
        פעיל,
        הוסר
    }

    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ContactStatus Status { get; set; }

        public Contact(int id, string firstName, string lastName, string email, string phone, ContactStatus status)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Status = status;
        }



    }
}
