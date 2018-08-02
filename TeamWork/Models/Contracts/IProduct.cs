namespace ElectronicsShop.Models.Interfaces
{
    public interface IProduct
    {
        string Name { get; }

        decimal Price { get; }
        
        int StaticId { get; set; }

        int RealID { get; set; }
    }
}