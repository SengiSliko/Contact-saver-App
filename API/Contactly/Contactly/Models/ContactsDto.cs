namespace Contactly.Models
{
    public class ContactsDto
    {

        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }

        public bool Favourite { get; set; }

    }
}
