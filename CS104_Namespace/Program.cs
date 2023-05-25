using static System.Console;

using MyNamespace;
using XYZ = MyNamespace.ABC;


namespace CS104_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.Phone product = new Product.Phone();
            product.Name = "Iphone13";
            product.Price = 1000;
            product.Description = "This is a brand new iphone!!!";
            product.manu.CompanyName = "Intel";
            WriteLine(product.GetInfo());
            WriteLine(product.manu.CompanyName);


        }
    }

}

