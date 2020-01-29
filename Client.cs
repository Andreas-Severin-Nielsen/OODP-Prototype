using System;

namespace OODP_Prototype
{
    public class Client
    {
        private IProduct product;
        private IPrototype prototype;

        public Client(IPrototype prototype)
        {
            this.prototype = prototype;
        }

        public string Operation()
        {
            product = prototype.Clone();
            return "Client: cloning " + prototype.GetType().Name + ".\n"
                + product.Name + " object copied.";
        }
    }
}