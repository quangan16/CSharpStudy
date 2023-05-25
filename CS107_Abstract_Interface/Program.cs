

namespace CS107_Abstract;
class Program
{
    //virtual method
    abstract class Product
    {
        protected double Price { get; set; }
        public Product() { 
            this.Price = 100;
            Console.WriteLine(this.Price);
        }
        public abstract void ProductInfo();
       
        public void Test1() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => this.Price= 500;
        public override void ProductInfo()
        {
            
            Console.WriteLine("Gia dien thoai Iphone:" + base.Price);
        }
    }

    class Samsung : Product
    {
        public Samsung() => Price = 400;
        public override void ProductInfo()
        {
            Console.WriteLine("Gia dien thoai Samsung:" + base.Price);
        }
    }
    //___________________________________________________________________________

    //Interface
    interface IShape
    {
        double TinhChuVi();
        double TinhDienTich();

    }

    class HinhChuNhat : IShape
    {
        public double a { get; set; }
        public double b { get; set; }
        public HinhChuNhat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        public double TinhChuVi()
        {
            return 2 * ( a + b);
        }

        public double TinhDienTich()
        {
            return 2 * a * b;
        }
    }

    class HinhTron : IShape
    {
        public double r { get; set; }
        public HinhTron(double _r) => this.r = _r;
        public double TinhChuVi() => Math.PI * r * 2;
        public double TinhDienTich() => Math.PI * r * r;
        

    }


    static void Main(string[] args)
    {
        //Iphone iphone1 = new Iphone();
        //iphone1.Test1();

        //Samsung samsung1 = new Samsung();
        //samsung1.ProductInfo();

        IShape h = new HinhChuNhat(5, 10);
        Console.WriteLine($"Dien tich: {h.TinhDienTich()} / Chu vi: {h.TinhChuVi()}");

        IShape t = new HinhTron(1);
        Console.WriteLine($"Dien tich: {t.TinhDienTich()} / Chu vi: {t.TinhChuVi()}");


    }
}
