using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C# 기본 문법 시작
// 시작은 Hello World부터
namespace HelloCsharpWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //write는 줄바꿈을 하지 않는다
            Console.WriteLine("C# hello world"); 
            Console.WriteLine("C#에 온 것을 환영합니다.");
            Console.WriteLine("{0} {1}", args[1], args.Length-1);
        }
    }
}
 
