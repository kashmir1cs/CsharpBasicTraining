using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 인덱서 사용
// TryParse() 리턴값은 실패시 0 첫번째 인자 - 숫자로 변환될 문자열, 두번째 인자 - Out 키워드를 붙여서 매개변수 작성
namespace CsharpBasicChaptor0901
{
    class Tiger
    {
        int i;
        public int this[int idx] //인덱서 선언 방법
        {
            get { return i; }
            set
            {
                i = value; // i에 할당 
                Console.WriteLine("Tiger No :" + idx); 
            }
        }
    }

    // 읽기 전용 인덱서
    class Eagle
    {
        public int this[int idx] //인덱서 선언 방법
        {
            get { return idx*idx; } // read only
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Eagle e = new Eagle();
            Tiger t = new Tiger();
            Console.WriteLine(e[5]); //인덱서 get
            Console.WriteLine(t[10]); //인덱서 get 동작 i에 할당된게 없기 때문에 0을 출력함
            // Tiger 클래스는 지정도 가능함
            t[55] = 10; //set, i에 10 할당 55번 방에 10을 할당함
            // t[55] = 10에서 10은 어디에 할당 되는가?
            Console.WriteLine(t[55]);

        }
    }
}
