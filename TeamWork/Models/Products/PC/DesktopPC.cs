namespace ElectronicsShop.Models.Products
{
    public class DesktopPC : PC
    {
        private const string ProductName = "DesktopPC";
       public DesktopPC(string brand, string model, string processor, int ram, int hdd, int videoCard, decimal price)
            : base(processor, ram, hdd, videoCard, ProductName, price, brand, model)
        {

        }
    }
}
