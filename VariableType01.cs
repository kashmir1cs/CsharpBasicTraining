using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaptor02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte 표현범위는 0~255, 양수만, size= 1 byte (8bit)
            byte a = 100;
            a = 255;
            Console.WriteLine(a);
            //sbyte 변수 범위:  -128 ~127, 1 byte(8bit)
            sbyte b = -55;
            Console.WriteLine(b);
            short c = 32767; //2 byte 자료형 범위 :  -32768 ~ 32767
            Console.WriteLine(c);
            ushort d = 200; //2 unsigned short 2 byte, 범위 : 양수 0~ 65535
            Console.WriteLine(d);
        }
    }
}
