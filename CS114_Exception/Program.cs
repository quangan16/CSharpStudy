using MyException;

namespace CS114_Exception;
class Program
{
    static void Main(string[] args)
    {
        //int a = 6;
        //int b = 1;
        //float[] flArr = { 3.5f, 6.4f, 8.9f };
        //try
        //{
        //    int c = a / b;
        //    Console.WriteLine(flArr[3]);

        //}
        //catch(DivideByZeroException e)
        //{
        //    Console.WriteLine(e.Message);
        //    Console.WriteLine(e.StackTrace);
        //    Console.WriteLine("Khong the chia cho 0");
        //}
        //catch (IndexOutOfRangeException e)
        //{
        //    Console.WriteLine(e.Message);
        //    Console.WriteLine(e.StackTrace);
        //    Console.WriteLine("Vuot qua phan tu mang co the truy cap");


        //}

        //string path = null;
        //try
        //{
        //    string s = File.ReadAllText(path);
        //    Console.WriteLine(s);
        //}
        //catch(FileNotFoundException e)
        //{
        //    Console.WriteLine(e.Message);
        //    Console.WriteLine(e.StackTrace);
        //    Console.WriteLine("Khong tim thay file");
        //}
        //catch (ArgumentNullException)
        //{
        //    Console.WriteLine("Duong dan file phai khac null!");
        //}
        //catch(Exception e)
        //{
        //    Console.WriteLine(e.StackTrace);
        //    Console.WriteLine("Sai!!!");
        //    Console.WriteLine(e.GetType().Name);
        //}

        static void Register(string name, int age)
        {
            Exception exception;

            if (string.IsNullOrEmpty(name))
            {
                //exception = new Exception("Name must not be null!!");
                //throw exception;
                throw new NameEmptyException();
            }
            if( age < 16 || age > 65)
            {
                //exception = new Exception("Your age is not suitable to register!!!");
                //throw exception;
                throw new AgeException(age);
            }
            Console.WriteLine("Hello " + name);
        }

        try
        {
            Register("An", 22);

        }
        catch(AgeException e)
        {
            Console.WriteLine(e.Message);
            e.Detail();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
