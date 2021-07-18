using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 반복문 : do while , for each
// continue, break 사용 예시
namespace CsharpBasicChaptor04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            do //한번은 무조건 실행
            {
                Console.WriteLine("Iteration 연습");
                x = Console.ReadLine();
            } while ((x != "q") && (x != "Q")); // 'q'가 입력되기 전까진 계속 실행한다.



            // for each문 : 배열과 같은 collection 개체를 활용할 때 사용
            // 배열선언 = 변수타입 []
            string[] ListofFood =  { "Pizza", "Spaghetti", "Ramen" };
            int[] y = { 55, 761, 61, 3, -9 };
            foreach (string i in ListofFood)
            {
                // ListofFood에서 하나식 String 꺼내서 출력
                Console.WriteLine(i);
            }

            foreach (int j in y)
            {
                // ListofFood에서 하나식 String 꺼내서 출력
                Console.WriteLine(j);
            }

            // foreach문을 for문으로 변환할 경우 인덱싱 지정 필요 
            // 인덱싱은 0번부터 시작 : 파이썬과 동일 (R은 1번부터 시작)


            for (int i=0;i<5;i++)
            {
                Console.WriteLine("foreach대신 for문으로도 사용가능");
                Console.WriteLine(y[i]);
            }

            // for문에서 break 사용
            Console.WriteLine("for문 + break활용");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("break 조건 도달");
                    break; 
                    //인덱스 3번 이되었을 때 탈출 
                    //인덱스 2번까지만 콘솔에 출력 
                }
                Console.WriteLine(y[i]); //i가 3이 되기 전가진 반복문 계속 수행 
            }
            Console.WriteLine("continue : 다음 Step으로 강제 진행");
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                    //인덱스 3번 항목 출력 X
                    // 4번째 원소인 3은 콘솔창에 출력 안됨
                }
                Console.WriteLine(y[i]); //index 3번 (실제로는 4번째 원소)을 제외한 원소 출력됨 
            }
        }
    }
}
