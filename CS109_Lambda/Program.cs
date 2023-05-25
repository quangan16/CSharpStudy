namespace CS_Lambda
{

    /*
     * Lambda - Anonymous function
     * (1)  (int a, int b) => bieu_thuc;
     *
     * (2)  (tham_so) => {
     *      cac_bieu_thuc;
     *      return bieu_thuc_tra_ve;
     * }
     * 
     * 
     * 
     */


    class Program
    {
        static void Main(string[] args)
        {
            Action<string> thongBao1;
            thongBao1 = (string s) => Console.WriteLine(s); //~ delegate void KIEU(string s) == Action<string>

            for (int i = 0; i < 10; i++)
            {
                thongBao1?.Invoke("Xin chao " + (int)(i + 1));
            }

            Action thongBao2;
            thongBao2 = () => Console.WriteLine("Tuong lambda nhu nao :))");
            thongBao2?.Invoke();

            Action<string, decimal> welcome;
            welcome = (s, d) => Console.WriteLine(s + " " + d);
            welcome?.Invoke("My birthday is on", 16);
            welcome?.Invoke("Today's lucky number is", 3645);


            welcome = (msg, id) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(msg + " " + id);
                Console.ResetColor();
            };

            welcome?.Invoke("My student's ID is", 1610);


            Func<int, int, int> calculate;
            calculate = (int a, int b) =>
            {
                return a + b;
            };

            Console.WriteLine(calculate?.Invoke(5, 6));
        }
    }

}


