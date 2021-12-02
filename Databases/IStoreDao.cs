using Storage.OrderSystem;

namespace Storage.Databases
{
    public interface IStoreDao
    {
        bool Connect(string url);
        bool Disconnect();
        bool InsertProduct(Product product);
        Product ReadProduct(int id);
        Product[] ReadAllProducts();
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}