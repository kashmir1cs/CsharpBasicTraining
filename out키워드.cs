using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// out 키워드 활용

namespace CsharpBasicChaptor0901_01
{
    class Chap0901_01
    {
        static void Main(string[] args)
        {
            int outValue;
            bool result = int.TryParse(Console.ReadLine(), out outValue); // 입력값이 숫자면 True 반환, 아니면 False 반환
            Console.WriteLine(result); // 입력값이 숫자가 아닐 경우 False 출력, 숫자면 True 출력
            Console.WriteLine(outValue); //입력값이 숫자가 아닐 경우 0 반환, 숫자면 그대로 숫자 출력
        }
    }
}
