using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 배열 실습
namespace CsharpBasicChaptor08_03
{
    class Chap0803
    {
        static void Main(string[] args)
        {
            // 배열 선언은 []사용
            int[] locker;
            locker = new int[5];  // 한줄로 표현 가능 int[] locker =new int[5];
            // 배열 원소초기화
            locker[0] = 1;
            locker[1] = -11;
            locker[2] = 55;
            locker[3] = 9;
            locker[4] = 999;

            //반복문 실행1
            for (int i = 0; i < locker.Length; i++)
            {
                Console.WriteLine(locker[i]);
            }
            //반복문 실행2
            foreach (int i in locker) Console.WriteLine(i); //값을 하나씩 꺼내서 출력

            //다차원 배열
            int[,] numbers = new int[3, 2] { { 0, 99 }, { 1, 99 }, { 3, 55 } }; //3행2열 배열 선언 후 초기화
            //다차원배열은 foreach문이 유리
            //for (int i = 0; i < 3; i++)
            //    for (int j = 0; j < 2; j++)
            //        Console.WriteLine(numbers[i,j]);
            foreach (int i in numbers) Console.WriteLine(i);
        }
    }
}
