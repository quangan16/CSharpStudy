using System;
namespace Product
{
    public partial class Phone
    {
        public String Description { get; set; }
        public void GetName()
        {
            System.Console.WriteLine(this.Name);
        }

        public class Manufactory
        {
            public string CompanyName { get; set; }
            public string Address { get; set; }
        }

        public Manufactory manu = new Manufactory();
        
    }
}

