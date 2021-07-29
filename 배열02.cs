using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicChaptor08_04
{
    class Chap0804
    {
        static void Main(string[] args)
        {
            int[][] let = new int[3][]; //가변 배열 을 선언
            let[0] = new int[4] { 65, 15, -31, 34 };
            let[1] = new int[] { 5, 10, 15};
            let[2] = new int[] { 6, 12, 18 };
            Console.WriteLine("변수 let의 길이는 {0}",let.Length);
            foreach(int[] arr in let)
            {
                Console.Write("길이 : {0} ", arr.Length);
                foreach (int e in arr)
                {
                    Console.Write("원소 : {0} ", e);
                }
                Console.WriteLine("");
            }


        }
    }
}
