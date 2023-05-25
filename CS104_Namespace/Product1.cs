using System;
namespace Product
{
    public partial class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public String GetInfo()
        {
            return $"{Name} / {Price} / {Description}";
        }
    }
}

