using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 조건문 연습
namespace CsharpBasicChaptor04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF/ ELSE/ Switch
            int x = 3, y = 1;
            if (x < 7) //중괄호 활용하여 IF 실행 범위 구분
            {
                Console.WriteLine("IF가 참이면 실행!");
                Console.WriteLine("IF문은 ';' 까지만 출력");
            }

            if (x < y)
            {
                Console.WriteLine("IF가 참이면 실행");
            }
            else
            {
                Console.WriteLine("Else문 실행");
            }
            Console.WriteLine("IF문은 세미콜론/중괄호사용하여 범위 지정가능");

            Console.WriteLine("ELSE- IF");
            if (x < y)
            {
                Console.WriteLine("IF가 참이면 실행");
            }
            else if(x!=y)
            {
                Console.WriteLine("IF가 False일때 실행");
                Console.WriteLine("Else IF 문 실행");
            }
            else
            {
                Console.WriteLine("Else문 실행");
            }

            // switch문 (조건이 여러개일 때 실행)
            // break 붙일것,
            // default는 CASE가 없을 경우 실행하는 부분

            int z = 111;
            Console.WriteLine("switch 구문");
            switch (z) //case별로 정리
            {
                case 1:
                    Console.WriteLine("z=1");
                    break;
                case 10:
                    Console.WriteLine("z=10");
                    break;
                default:
                    Console.WriteLine("Case가 없음");
                    break;
            }

        }
    }
}
