using Student;

namespace CS106_Anonymous_Dynamic;
class Program
{
    //Anonymous - kieu du lieu vo danh
    //Object - thuoc tinh - chi doc
    //new {thuoctinh = gia tri, thuoctinh2 = giatri2}


    //Dynamic - kieu du lieu dong
    static void PrintInfo(dynamic obj)
    {
        obj.Name = "AnNguyen";
        obj.Hello();
    }


    class Student{
        public string Name { get; set; }
   
        public void Hello()
        {
            Console.WriteLine("Hello from " + this.Name);
        }

    }

        


    static void Main(string[] args)
    {
        //var sanPham = new {
        //    ten = "Iphone 8",
        //    gia = 1000,
        //    namSx = 2018
        //};
        //// sanPham.ten = "andy"; !!!!

        //Console.WriteLine(sanPham.ten);
        //Console.WriteLine(sanPham.gia);
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //List<Student.Student> studentList = new List<Student.Student>()
        //    {
        //        new Student.Student(){FullName = "Andy", Birth = 2001, ID = "123"},
        //        new Student.Student(){FullName = "Benny", Birth = 2003, ID = "234"},
        //        new Student.Student(){FullName = "Jack", Birth = 1997, ID = "345"},
        //        new Student.Student(){FullName = "Gwen", Birth = 2005, ID = "456"},
        //    };

        //var resultList = from student in studentList
        //                 where student.Birth <= 2002
        //                 select new
        //                 {
        //                     fullname = student.FullName,
        //                     birth = student.Birth
        //                 };

        //foreach (var student in resultList){
        //    Console.WriteLine(student.fullname + "-" + student.birth);
        //}

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Student stu1 = new Student();

        //PrintInfo(stu1);
        stu1?.Hello();

        int? age;
        age = 10;
        if (age.HasValue)
        {
            int _age = (int)age;
            Console.WriteLine(_age);
        }
        
    }
}
