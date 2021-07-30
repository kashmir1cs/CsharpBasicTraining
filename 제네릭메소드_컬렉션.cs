using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 제네릭 메소드
// 제네릭 콜렉션
namespace CsharpBasicChaptor1002
{
    class Chap10_02
    {
/*
        // 두 수를 교환하는 메소드 작성 : 일반적인 방법
        static void Change(ref int l, ref int r)
        {
            int t; // 왼쪽 수 저장할 임시 변수
            t = l;
            l = r;
            r = t;  // 왼쪽수를 오른쪽에 입력
        }
*/
        // 두 수를 교환하는 메소드 작성 : 제네릭 메소드 적용
/*
        static void Change<T>(ref T l, ref T r)
        {
            T t; // 왼쪽 수 저장할 임시 변수
            t = l;
            l = r;
            r = t;  // 왼쪽수를 오른쪽에 입력
        }
*/

/*
        public static void NumChange()
        {

            // 일반적인 방법을 활용한 방법
            string e = "안녕하세요";
            string f = " 대한민국";
              
            int a = 1;
            int b = 2;
            float c = 34.162f;
            float d = 4.264f;

            Console.WriteLine("바뀌기전의 숫자는 다음과 같습니다.");
            Console.WriteLine(" {0}  {1} ", a, b);
            Change<int>(ref a, ref b);
            Console.WriteLine("바뀐 후의 숫자는 다음과 같습니다.");
            Console.WriteLine(" {0}  {1} ", a, b);

            Console.WriteLine("바뀌기전의 숫자는 다음과 같습니다.");
            Console.WriteLine(" {0}  {1} ", c, d);
            Change<float>(ref c, ref d);
            Console.WriteLine("바뀐 후의 숫자는 다음과 같습니다.");
            Console.WriteLine(" {0}  {1} ", c, d);

            Console.WriteLine("바뀌기전의 숫자는 다음과 같습니다.");
            Console.WriteLine(" {0}  {1} ",e, f);
            Change<string>(ref e, ref f);
            Console.WriteLine("바뀐 후의 숫자는 다음과 같습니다.");
            Console.WriteLine(" {0}  {1} ", e, f);


        }*/
        
        static void Main(string[] args)
        {

            //NumChange();

            // Stack 형식 : 변수 제약 없음
            // Stack 형식 단점 : 형변환이 필요하므로 성능 저하
            Stack s = new Stack();
            s.Push(-9);
            s.Push(23);
            s.Push("Nine");
            s.Push(3.246f);

            while(s.Count!=0)
            {
                Console.WriteLine(s.Pop());
            }

            //제네릭 컬렉션
            // 같은 타입의 변수만 처리하므로 속도가 향상된다.
            Stack<float> st = new Stack<float>(); 
            st.Push(-9);
            st.Push(23);
            //st.Push("Nine");
            st.Push(3.246f);

            while (st.Count != 0)
            {
                Console.WriteLine(st.Pop());
            }

            // 딕셔너리 컬렉션 (hashtable에 대응)
            // 변수 형태를 특정할 수 있음
            Dictionary<float, string> dc = new Dictionary<float, string>();
            dc[1.0f] = "ver0.1";
            dc[1.1f] = "ver0.2";
            dc[1.2f] = "ver0.3";
            dc[1.3f] = "ver0.4";
            Console.WriteLine(dc[1.0f]);
            Console.WriteLine(dc[1.1f]);
            Console.WriteLine(dc[1.2f]);
            Console.WriteLine(dc[1.3f]);




        }
    }
}
