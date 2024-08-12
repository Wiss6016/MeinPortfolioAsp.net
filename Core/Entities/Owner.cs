namespace Core.Entities
{
    internal class Owner : EntityBase
    {
        public string? FullName  { get; set; }
        public string? Profil { get; set; }
        public int Avatar { get; set; }
        public Address? Address { get; set; }
    }
}
