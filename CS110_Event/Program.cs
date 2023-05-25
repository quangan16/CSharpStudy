
namespace CS_Event
{
    /* Event in CSharp
     * 
     * Publisher -> class - phat su kien
     * 
     * Subcriber -> class - nhan su kien
     * 
     * 
     */

    class InputData : EventArgs
    {
        public int data { set; get; }
        public InputData(int x) => data = x;
        
    }

    public delegate void Deleg(int x);

    //publisher
    class InputHandler
    {
        //public event Deleg event1;
        public event EventHandler event2; //~ delegate void Kieu(object? sender, EventArgs args)
        public void Input()
        {
            do
            {
                Console.Write("Nhap vao 1 so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phat di su kien ...
                event2.Invoke(this, new InputData(i));
            }
            while (true);
        }
    }

    //subcriber
    class SqrtCalculate
    {
        //Ham dang ky su kien nhap so
        public void Subcribe(InputHandler input)
        {
            input.event2 += sqrt;
        }

        public void sqrt(object sender, EventArgs e)
        {
            InputData inputData = (InputData)e;
            int x = inputData.data;
            Console.WriteLine($"The square root of {x} is: {Math.Sqrt(x)}");
        }
    }

    class SquareCalculate
    {
        public void Subcribe(InputHandler input)
        {
            input.event2 += square;
        }
        public void square(object sender, EventArgs e)
        {
            InputData inputData = (InputData)e;
            int x = inputData.data;
            Console.WriteLine($"Square of {x} is: {x * x}");
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {

            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Closing...");
            };
            //publisher
            InputHandler inputHandler = new InputHandler();

            inputHandler.event2 += (object sender, EventArgs e) =>
            {
                InputData data = (InputData)e;
                Console.WriteLine("Ban vua nhap so: " + data.data);
            };

            //subcriber1
            SqrtCalculate sqrtCal = new SqrtCalculate();
            sqrtCal.Subcribe(inputHandler);
            //inputHandler.Input();

            //subcriber2
            SquareCalculate squareCal = new SquareCalculate();
            squareCal.Subcribe(inputHandler);
            inputHandler.Input();

            
        }
    }
}

