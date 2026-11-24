namespace WebApplication1.Clasess
{
    public class ContactData
    {
        public static List<Contact> contacts { get; } = new()
        {
            new Contact(1, "דוד", "כהן", "david.cohen@example.com", "050-1234567", ContactStatus.פעיל),
            new Contact(2, "שרה", "לוי", "sara.levi@example.com", "052-2345678", ContactStatus.פעיל),
            new Contact(3, "יוסי", "מזרחי", "yossi.mizrahi@example.com", "054-3456789", ContactStatus.הוסר),
            new Contact(4, "רחל", "פרץ", "rachel.peretz@example.com", "055-4567890", ContactStatus.פעיל)
        };
    }
}
