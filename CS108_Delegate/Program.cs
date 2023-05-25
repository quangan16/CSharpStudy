namespace CS_Delegate
{
    public delegate void ShowLog(string message);
    class Program
    {

        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public delegate int Delegate();


        static void Sum(int a, int b, ShowLog log)
        {
            int res = a + b;
            log?.Invoke($"Sum is {res}");
        }


        static int Subtract(int a, int b) => a - b;

        static void Main(string[] args)
        {
            //ShowLog log = null;

            //log += Info;
            //log += Warning;
            //log += Info;


            //log += Warning;
            //log += Info;

            ////log("Xin chao");
            ////log.Invoke("Xin chao Abc");
            ////log?.Invoke("Andy noice");

            ////log = Warning;
            ////log?.Invoke("Delegate don gian vlz");


            //log?.Invoke("Xin chao cac ban!!");


            //____________________________

            //Action, Func : delegate - generic\

            //Action action1;             //~ delegate void KIEU();
            //Action<string, int> action2;// ~ delegate void KIEU(string s, int i)

            //Action<string> action3;    //~ delegate void KIEU(string s)
            //action3 = Warning;
            //action3 += Info;
            //action3?.Invoke("Thong bao Thong bao");

            //Func<int> f1;   //~ delegate int KIEU();
            //Func<string, double, string> f2;
            //Func<int, int, int> f3; //~ delegate int KIEU(int a, int b);
            //f3 = Sum;
            //f3 += Subtract;
            //int a = 5;
            //int b = 10;
            //Console.WriteLine(f3?.Invoke(a, b));


            //Sum(4, 5, Info);


            int[] arr = { 2, 4, 6, 8, 9, 11 };
            var res = arr.Select((int x) =>
            {
                return Math.Sqrt(x);
            });

            //foreach (var result in res)
            //{
            //    Console.WriteLine(result);
            //}

            //arr.ToList().ForEach(
            //    (int x) =>
            //    {
            //        if(x %2 != 0)
            //        {
            //            Console.WriteLine(x);
            //        }
            //    }
            //);

            var res1 = arr.Where(
                x =>  x>=4 && x<50
                
            );
            foreach(var n in res1)
            {
                Console.WriteLine(n);
            }
        }
    }
}

