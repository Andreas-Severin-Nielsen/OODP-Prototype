namespace OODP_Prototype
{
    public class Product1 : IProduct, IPrototype
    {
        private string name;

        public Product1(string name)
        {
            this.name = name;
        }

        public Product1(Product1 p)
        {
            this.name = p.Name;
        }

        public string Name { get; set; }

        public IProduct Clone()
        {
            return new Product1(this);
        }
    }
}