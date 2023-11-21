namespace CS109_Lambda_Practice
{
    delegate int CountDele(int num);

    internal class Program
    {

        static void Main(string[] args)
        {

            //Action<int> count = (num) =>
            //{
            //    Console.WriteLine(num);

            //};


            //CountDele count = (num) => { return num -1; };
            //count += (floatt) => { Console.WriteLine(floatt +1 ); return floatt + 2; };
            //count += (floatt) => { Console.WriteLine(floatt +4 ); return floatt + 5; };
            //   //Console.WriteLine(count?.Invoke(3));

            //var results = count?.GetInvocationList().Select(x => (int)x.DynamicInvoke(10));
            //    foreach (var result in results)
            //        Console.WriteLine(result);

            //}

            int[] mang = { 2, 3, 4, 5, 6, 7, 8 };
            var res = mang.Where((int x) =>
            {
                return x%2 ==0;
            });
            foreach(var re in res)
            {
                Console.WriteLine(re);
            }
        }
    }
}




