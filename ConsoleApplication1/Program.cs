using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

   public class Program
    {
        public  static int [] MakeAnagram(int n,int d,int [] arr)
        {
            if (!(n >= 1 && n <= System.Math.Pow(10, 5)))
            {
                return null;
            }
            if (!(d >= 1 && d <= n))
            {
                return null;
            }

            int[] anagram = new int[n];
            int[] dArr = new int[d];
            

            int i = 0;
            //populate anagram
            for(int j = d; j < n; j++)
            {
                anagram[i] = arr[j];
                i++;
            }

            for(int k = 0; k < d; k++)
            {
                anagram[i] = arr[k];
                i++;
            }

            return anagram;
        }
        static void Main(string[] args)
        {
            var anagrm = MakeAnagram(5, 4, new int[5] { 1, 2, 3, 4, 5 });
            
            
        }
    }
}