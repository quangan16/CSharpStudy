using System.Text;

namespace CS119;
class Program
{

    class Product{
        public int ID{get; set;}
        public double Price{get;set;}
        public string Name{get;set;}
        public void Save(Stream stream){
            var bytes_id = BitConverter.GetBytes(ID);
            stream.Write(bytes_id, 0, 4);
            var bytes_price = BitConverter.GetBytes(Price);
            stream.Write(bytes_price, 0, 8);
            foreach (byte b in bytes_price)
            {
                Console.Write(b + " ");
            }
            var bytes_name = Encoding.UTF8.GetBytes(Name);
            var bytes_leng =  BitConverter.GetBytes(bytes_name.Length);
            stream.Write(bytes_leng);
            stream.Write(bytes_name, 0, bytes_name.Length);
        }

        public void Restore(Stream stream){
            byte[] bytes_id = new byte[4];
            stream.Read(bytes_id, 0, 4);
            this.ID = BitConverter.ToInt32(bytes_id, 0);

            byte[] bytes_price = new byte[8];
            stream.Read(bytes_price, 0, 8);
            this.Price = BitConverter.ToDouble(bytes_price, 0);
            
            byte[] bytes_leng = new byte[4];
            stream.Read(bytes_leng, 0, 4);
            int leng = BitConverter.ToInt32(bytes_leng, 0);

            var bytes_name = new byte[leng];
            stream.Read(bytes_name, 0, leng);
            this.Name = Encoding.UTF8.GetString(bytes_name);
        }
    }

    //File ============================================
    static void Main(string[] args)
    {
        string path = "data.txt";
        using FileStream stream = new FileStream(path: path, FileMode.Open);

        // FileInteraction();
        // FileStreamInteraction();
        Product product1 = new Product();
       
        product1.Restore(stream);
        Console.WriteLine($"{product1.Name} - {product1.Price} - {product1.ID}");
    }

    public static void FileInteraction(){
        string filename = "test.txt";
        string content = "Hello World3!!!\n";
        File.AppendAllText(filename, content);
        var s  = File.ReadAllLines(filename);
        foreach(var i in s){
            System.Console.WriteLine(i);
        }
        // File.Copy("test.txt", "test2.txt");
        File.Delete("test2.txt");
    }

    public static void FileStreamInteraction(){
        string path = "data.dat";
        byte[] buffer = {1,2,3};
        FileStream stream = new FileStream(path: path, FileMode.OpenOrCreate);
        stream.Write(buffer, 0, 3);
        stream.Read(buffer, 0, 3);

        //int , double ,... -> bytes
        int abc = 1;
        var byte_abc = BitConverter.GetBytes(abc);
        string s = "Abc";
        var byte_s = Encoding.UTF8.GetBytes(s);

        Encoding.UTF8.GetString(byte_s, 0, 10);

    }
}
