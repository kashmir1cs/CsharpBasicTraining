using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicChaptor02_02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 부동 소수점 : float (4byte), double (8byte)
            // IEEE 754 : 부동 소수점 표현방식
            float f = 3.14f; //접미사 f 추가해야함
            double d = 3.14;
            // 범수 변위가 다름
            Console.WriteLine(f / 3);
            Console.WriteLine(d / 3); // 값이 더 정확하게 계산되어 나옴
            // 문자, 문자열
            char c = 'K'; /*문자는 작은따옴표사용*/
            string s = "IT Csharp Basic";
            Console.WriteLine(c);
            Console.WriteLine(s);
            // 논리형 boolean;
            bool b1 = true;
            bool b2 = true;
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b1&&b2);


        }
    }
}
