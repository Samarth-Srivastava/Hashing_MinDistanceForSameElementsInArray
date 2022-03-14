//driver code
using System;
using System.IO;
using System.Collections.Generic;

namespace Hashing_MinDistanceForSameElementsInArray{
    public class Program{
        public static void Main(string[] args){
            Solution s = new Solution();
            
            List<int> lst = new List<int>();
            foreach (var item in args)
            {
                lst.Add(Convert.ToInt32(item));
            }

            Console.WriteLine(s.solve(lst));
        }
    }
}