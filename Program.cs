using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Product1("Product1"));
            Console.WriteLine(client.Operation());
            Console.ReadKey();
        }
    }
}
