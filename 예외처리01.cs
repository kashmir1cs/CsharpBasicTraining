using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 예외 발생 및 처리 
// try, catch, finally
// catch는 여러개 사용 가능
namespace CsharpBasicChaptor1101
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("첫번째 숫자:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("두번째 숫자:");
                int y = int.Parse(Console.ReadLine());
                float z = x / y;
                Console.WriteLine(z);
                // 배열 코드 작성
                int[] a1 = new int[4]; //인덱스 0~3까지
                a1[0] = 9;
                a1[1] = 55;
                a1[2] = 13;
                a1[3] = -565;
                for (int i = 0; i < 5; i++) Console.WriteLine(a1[i]);
            }
            catch (DivideByZeroException e) //Exception : 모든 종류의 예외를 처리함
            {
                Console.WriteLine("분모에 0이 올수 없습니다.");
                Console.WriteLine("예외 종류 : " + e.GetType());
                Console.WriteLine(e.Message);//시스템이 제공해주는 메세지
            }
            catch (IndexOutOfRangeException e) //Exception : 모든 종류의 예외를 처리함
            {
                Console.WriteLine("배열의 범위를 벗어 났습니다.");
                Console.WriteLine("예외 종류 : " + e.GetType());
                Console.WriteLine(e.Message);//시스템이 제공해주는 메세지
            }
            catch (FormatException e)
            {
                Console.WriteLine("입력값이 맞지 않습니다");
                Console.WriteLine("예외 종류 : " + e.GetType());
                Console.WriteLine(e.Message);//시스템이 제공해주는 메세지
                Console.WriteLine(e.StackTrace); // 스택트레이싱
            }
            // Exception 가장 상위에 있는 오류
            // 에러 처리 구문의 가장 마지막에 등장해야함
            catch (Exception e)
            {
                Console.WriteLine("기타 예외가 발생하였습니다.");
                Console.WriteLine("예외 종류 : " + e.GetType());
                Console.WriteLine(e.Message);//시스템이 제공해주는 메세지
            }

            finally  // 예외 발생 여부와 관계 없이 항상 실행
            {
                Console.WriteLine("프로그램 종료");

            }
        }
    }
}
