namespace CSharp_Web_Exercise.ViewModels.Product
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
