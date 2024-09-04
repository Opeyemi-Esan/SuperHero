namespace SuperHeroAPI_DotNet8.Entities
{
    public class MercylandContact
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required int Password { get; set; }
        public int PhoneNumber { get; set; }
        public required string Message { get; set; }
    }
}
