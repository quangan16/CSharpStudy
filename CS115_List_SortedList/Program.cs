using MyNameSpace;
namespace CS115
{
	class Program
    {
        static void Main(string[] args)
        {
            // List<int> myList = new List<int>(){ 1, 2, 3 };
            // int[] myArr = new int[]{10, 11, 12};
            // myList.Add(4);
            // myList.AddRange(new int[]{ 5,6,7,8 });
            // myList.Count();
            // myList.AddRange(myArr);
            // myList.Insert(8, 9);
            // myList.RemoveAt(3);
            // myList.Remove(13);
           
            // myList.Add(1);
            // foreach(var item in myList)
            // {
            //     Console.Write(item + ". ");
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine(myList[2]);
            // Console.WriteLine(myList.Count);
            // var n = myList.Find(
            //     (x) => (x % 2 ==0) 
            // );
            // var myList2 = myList.FindAll(
            //     (x) => (x % 5 ==0) 
            // );
            // foreach(var i in myList2){
            //     Console.WriteLine(i);
            // }
            
            List<Product> products = new List<Product>(){
                new Product(){Name = "Iphone", Price = 1000, ID = 111, Origin = "America"},
                new Product(){Name = "Samsung", Price = 1500, ID = 222, Origin = "Korea"},
                new Product(){Name = "Bphone", Price = 500, ID = 333, Origin = "Vietnam"},
                new Product(){Name = "Nokia", Price = 800, ID = 444, Origin = "japan"}
            };

            // var productHolder1 = products.Find(
            //     (p) => p.Origin == "Vietnam"
            // );
            // var productHolder2 = products.FindAll(
            //     (_product) => _product.Price>=1000
            // );


            // if(productHolder1 != null){
            //     Console.WriteLine(productHolder1.Name);
            // }

            // if(productHolder2 != null){
            //     foreach(var i in productHolder2 ){
            //         Console.WriteLine(i.Name + "/" + i.Price + "/" + i.ID);
            //     }
                
            // }
//============================================================================================
            // foreach(Product i in products){
            //     Console.Write(i.Name + "/ "+ i.Price + " ");
            // }
            // products.Sort((p1,p2)=>{
            //     if(p1.Price==p2.Price) return 0;
            //     else if(p1.Price<p2.Price) return -1;
            //     else if(p1.Price>p2.Price) return 1;
            //     return 0;
            // });
            // Console.WriteLine();
            // foreach(Product i in products){
            //     Console.Write(i.Name + "/" + i.Price + " ");
            // }
//=========================================================================================================
            SortedList<string, Product> products2 = new SortedList<string, Product>();
            products2["product1"] = new Product(){Name = "Iphone", Price = 1000, ID = 111, Origin = "America"};
            products2["product2"] =  new Product(){Name = "Samsung", Price = 1500, ID = 222, Origin = "Korea"};
            products2["product3"] =  new Product(){Name = "Bphone", Price = 500, ID = 333, Origin = "Vietnam"};
            products2.Add("product4", new Product(){Name = "Nokia", Price = 800, ID = 444, Origin = "japan"});

            var p = products2["product3"];
            Console.WriteLine(p.Name);

            var keys = products2.Keys;
            var values = products2.Values;
            products2.RemoveAt(3);
            foreach(var key in keys){
                Console.WriteLine(products2[key].Name);
            }
            foreach(KeyValuePair<string, Product> item in products2)
            {
                var key = item.Key;
                var value = item.Value;
                Console.WriteLine($"{key} = {value.Name}");
            }

            products2.Remove("product1");
            products2.RemoveAt(3);
            products2.Clear();
        }
    }
    
}
