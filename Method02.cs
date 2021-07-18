using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Method 재귀적호출
namespace CsharpBasicChaptor05_02
{
    class Chap0502
    {
        // Factorial 계산 (반복문 활용)
        static int Fact1(int n)
        {
            int s = 1;
            for (int i=n;i>0; i--) // 1씩 감소
            {
                s = s * i;
            }
            return s;
        }
        // Factorial 계산 (재귀호출 활용)
        static int Fact2(int n)
        {
            if (n <= 1) return 1; //입력값이 1이면 1반환
            return n * Fact2(n - 1); //재귀적으로 실행
            /*
              n=5일 경우 5* Fact2(4)         
              Fact2(4) = 4 * Fact2(3)
              Fact2(3) = 3 * Fact2(2)
              Fact2(2) = 2 * Fact2(1) 
            */
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fact1(5));
            Console.WriteLine(Fact2(5));
        }
    }
}
