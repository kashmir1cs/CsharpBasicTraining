using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicCharptor03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55;//값 형식의 변수 (중 괄호에서만 활용, 중괄호 끝나면 메모리에서 제거)
            object b = "C# Basic Object"; //참조 형식의 변수(형태 무관), 가비지 컬렉터에서 제거
            object c = 100;// 참조형식의 변수, 가비지 컬렉터에서 제거, 가비지 컬렉터에서 제거
            Console.WriteLine("{0} {1} {2}", a, b, c); //한번에 출력할 때 {0} {1}.... 사용 : 파이썬과 유사함
            short d = 30000; // 0111 0101 0011 0000(2)
            sbyte e = 127;
            // 주석 /**/ : 여러줄 주석으로 사용 
            //형변환 
            int f;
            f = e;
            Console.WriteLine("{0} {1} {2}", a, d, f); //한번에 출력할 때 {0} {1}.... 사용 : 파이썬과 유사함
            //명시적 형변환
            e = (sbyte)d; // 2byte 자료형인 short을 sbyte형으로 강제 형변환
            // 실제 값은 30000이지만 2byte 데이터가 날아가면서 48로 표기
            //0111 0101 0011 0000(2) --> 0011 0000(2)
            Console.WriteLine("{0} {1} {2}", a, d, e);
            // 다른 형태의 변수도 변환 가능 
            float g = 3.141592f;
            // 부동소수점값을 정수로 변형:소수점 삭제됨
            f = (int)g;//float 형을 int형으로 강제 변환, 소수점 삭제됨
            Console.WriteLine("{0}is f //{1} is g", f, g);
            /*주석처리는 여러줄도
            가능   (ctrl + shitf + /)*/

        }
    }
}
