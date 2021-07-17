using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 연산자 (Operator)
namespace CsharpBasicChaptor03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(55 + 3);//사칙연산 가능+,-,*,/
            Console.WriteLine(1523 % 64); // % :나머지 구하기 
            int a = 200;
            int b = 3;
            Console.WriteLine(a + b); //변수 활용한 연산도 가능 
            // 증가 연산자 : ++
            ++b; 
            a++;

            Console.WriteLine(b); // 4 출력
            Console.WriteLine(a); // 201 출력

            Console.WriteLine("======================================================"); 
            Console.WriteLine("증가연산자 차이 비교");
            int x = 55;
            Console.WriteLine(x++);// x 값 출력 후 x 연산 55 출력 후 x=56
            Console.WriteLine(++x);// x = x+1한 후 출력, x=57
            Console.WriteLine(++x);// x = 58
            Console.WriteLine(x++);// x = 58 +1 출력은 58
            Console.WriteLine(x);// x = 59
            Console.WriteLine("======================================================");
            Console.WriteLine("대입연산자 비교하기");
            x = 55;
            x += 1; // x++와 동일 
            Console.WriteLine(x);// x = 56
            x *=2; // x= x*2 와 동일 
            Console.WriteLine(x);// x = 112
            Console.WriteLine("======================================================");
            Console.WriteLine("비교연산자 비교하기");
            // 비교 연산자 : >,<, ==, >=, <=.!=
            x = 55;
            int y = 44;
            Console.WriteLine(x < y); //False 출력
            Console.WriteLine(x > y); //True 출력
            Console.WriteLine(x != y); //True 출력

        }
    }
}
