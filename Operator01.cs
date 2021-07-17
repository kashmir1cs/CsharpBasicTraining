using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 삼항 연산자 :식을 간편하게 입력 가능
 * 논리 연산자 : !, &&, || (not, and, or)
 * 비트 연산자 : >>, <<, &, |, ^, ~ (2진수로 변환)
 */
namespace CsharpBasicChaptor03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            int z;
            z = (x > y) ? x : y; // if else 축약형
            Console.WriteLine(z); // 7 출력
            string a;
            a = (x > y) ? "x가 큰수" : "y가 큰 수";
            Console.WriteLine(a); // "y가 큰 수" 출력
            // not 연산자 
            Console.WriteLine("{0} {1}", !false, !true); // "True False" 출력
            // And 연산자
            bool b = x != y && x < y;
            Console.WriteLine(b); // True 출력
            Console.WriteLine("{0} {1} {2}", x != y , x < y,(x != y && x < y)); // "True True True " 출력
            Console.WriteLine("{0} {1} {2}", x != y, x > y, (x != y && x > y)); // "True False False " 출력
            // Or 연산자
            Console.WriteLine("{0} {1} {2}", x != y, x > y, (x != y || x > y)); // "True False True " 출력
        }

    }
}
