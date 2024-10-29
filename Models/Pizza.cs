using Microsoft.EntityFrameworkCore;
namespace PizzeriaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public required string Name { get; set; }  // Richiede l’assegnazione di un valore
        public required string Description { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public required string Ingredients { get; set; }
    }
}
