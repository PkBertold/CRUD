namespace Elektronika.Models
{
    public class Alkatresz
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public string? MadeBy { get; set; }
        public string? Type { get; set; }

        public decimal ImportPrice { get; set; }
    }
}
