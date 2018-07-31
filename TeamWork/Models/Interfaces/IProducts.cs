namespace TeamWork.Models.Interfaces
{
    public interface IProduct
    {
        string Name { get; }

        decimal Price { get; }

        virtual string Print();

    }
}