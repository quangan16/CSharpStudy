using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace CS117;
class Program
{
    static void Main(string[] args)
    {

        // Dictionary --------------------------------------------------------------

        // Dictionary<string, double> dic1 = new Dictionary<string, double>(){
        //     ["first"] = 1.5,
        //     ["second"] = 2.6,
        //     ["third"] = 3.9,
        //     ["forth"] = 4.1
        // };
        // dic1["fifth"] = 5.0;
        // dic1.Add("sixth",6.8);
        // dic1.Remove("second");
        // var keys = dic1.Keys;
        // System.Console.WriteLine(dic1.Count);
        // // foreach(var i in dic1){
        // //     System.Console.WriteLine(i.Key);
        // // }
        // foreach(KeyValuePair<string, double> item in dic1){
        //     System.Console.WriteLine(item.Value);
        // }

        // dic1.Clear();
        // dic1.Remove("second");

        //HashSet========================================================================
        HashSet<int> set1 = new HashSet<int>{1,2,3,4,6,5};
        HashSet<int> set2 = new HashSet<int>{8,9,10,11,5};
        HashSet<int> set3 = (HashSet<int>) set1.Intersect(set2);
        foreach(var i in set3){
            System.Console.WriteLine(i);
        }
        System.Console.WriteLine(set3.Count);

    }
}
