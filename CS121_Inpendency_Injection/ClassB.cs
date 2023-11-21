namespace CS121_Inpendency_Injection
{
    internal class ClassB : IClass
    {
        public ClassB()
        {
            Console.WriteLine("Hello");
        }

        internal void DoSomethingB()
        {
            ClassC instanceC = new ClassC();
            Console.WriteLine("This is B");
            instanceC.DoSomethingC();
           
        }

        public void TestingInterface()
        {
            Console.WriteLine("This is B using interface");
        }

        internal int SetID()
        {
            int id = 1610;
            return id;
        }
    }
}