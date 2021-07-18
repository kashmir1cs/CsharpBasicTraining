using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 반복문 : for / while
namespace CsharpBasicChaptor04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int a = 10;
            Console.WriteLine("for문 연습");
            // for 문 (초기값 ; 조건식; 증감식)
            for (i=1; i <= a ;i++) // for문 반복, i는 1씩 증가
            {
                Console.WriteLine(i);
            }
            
            int x;
            string y;
            y = Console.ReadLine();
            x = int.Parse(y); // 문자변수를 정수로 변환
            

            for (i=1;i<10;i++)
            {
                Console.WriteLine("{0} * {1} = {2} ",x,i, x*i );
            }
            i = 1;
            Console.WriteLine("while문");
            while (i < 10)
            {
                Console.WriteLine("{0} * {1} = {2} ", x, i, x * i);
                i++; //연산자 증가하지 않을 경우 무한 Loop실행
            }


        }
    }
}
