namespace Storage.OrderSystem
{
    public class Product
    {
        //TODO : add some properties
        public Product(int id, string name, decimal cost)
        {
            Id = id;
            Name = name;
            Cost = cost;
        }
    
        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}