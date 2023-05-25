namespace CS120;
class Program
{
    static void DoSomething(int seconds, string msg, ConsoleColor color){
        // Thread.Sleep(6000);
        lock(Console.Out){
                Console.ForegroundColor = color;
                Console.WriteLine($"Starting ... ");
                Console.ResetColor();
            }
        for(int i = 1; i<= seconds; i++){
            lock(Console.Out){
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg, 10} {i, 2}");
                Console.ResetColor();
            }
             Thread.Sleep(1000);
           
        }
        lock(Console.Out){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"The end... ");
                Console.ResetColor();
            }
    }
    //asynchronous (multi thread)

    public static async Task Task2(){
         Task t2 = new Task(
            () =>{
                DoSomething(7, "T2", ConsoleColor.Gray);
            }
        ); //~  () => {}
        t2.Start();
        await t2;
        
        Console.WriteLine("T2 finished!");
        
    }

    public static async Task Task3(){
        Task t3 = new Task((Object ob) => {
            string taskName = (string) ob;
            DoSomething(4, taskName, ConsoleColor.Magenta);
        }, "T3"); // ~ (Object ob) => {}
        
        t3.Start();
        
        await t3;
        Console.WriteLine("T3 finished");
        
    }
    static async Task Main(string[] args)
    {
        // synchronous
        // DoSomething(7, "T2", ConsoleColor.Cyan);
        // DoSomething(4, "T3", ConsoleColor.Magenta);
        // Console.WriteLine("Hello, World!");

        //asynchronous
        //Task

        // Task t2 = new Task(
        //     () =>{
        //         DoSomething(7, "T2", ConsoleColor.Gray);
        //     }
        // ); //~  () => {}

        Task t2 = Task2();
       
        // Task t3 = new Task((Object ob) => {
        //     string taskName = (string) ob;
        //     DoSomething(4, taskName, ConsoleColor.Magenta);
        // }, "T3"); // ~ (Object ob) => {}

        Task t3 = Task3();
        
        // t2.Start(); // Thread 2
        // t3.Start(); // Thread 3
        DoSomething(5, "T1", ConsoleColor.DarkGreen);//  Thread 1
        // DoSomething(5, "T1", ConsoleColor.DarkGreen);//  Thread 1
        // t2.Wait();
        // await t2;
        // t3.Wait();
        // await t3;
        // Task.WaitAll(t2, t3);
        Console.WriteLine("Press any key ...");

        Console.ReadKey();
        
    }
}
