namespace CS112;
class CountNumber
{
    private static int count = 10;
    public static void Info()
    {
        Console.WriteLine(count);
    }
}

class Student
{
    private static int studentQuantity = 0;
    private readonly string name;
    public Student(string _name)
    {
        studentQuantity++;
        this.name = _name;
        Console.WriteLine("This is student number {0:F2}", studentQuantity);
    }
    //public readonly string Name { get; set; }
    public string GetName()
    {
        return this.name;
    }
    //public void SetName(string _name)
    //{
    //    this.name = _name;
    //}
}

class Program
{
    static void Main(string[] args)
    {
        //CountNumber.Info();
        Student stu1 = new Student("Nguyen Van Binh");
        Student stu2 = new Student("Huy");
        //stu2.SetName("Nguyen Van A");
        Console.WriteLine(stu2.GetName());
    }
}
