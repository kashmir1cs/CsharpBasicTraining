using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// deep copy/ shallow copy 비교
// shallow copy : 얕은 복사, 같은 메모리 공간 참조하므라 원본도 값이 바꾸니다.
// deep copy : 참조하는 주소가 각각 존재 원본 값은 바뀌지 않는다.
namespace CsharpBasicChaptor06_02
{
    class TestCopy
    {
        public int x;
        public int y;
        // deep copy용 method 생성
        public TestCopy HardCopy() // Testcopy는 return type
        {
            TestCopy newCopy = new TestCopy();// 객체생성, 별도의 heap 공간 할당
            newCopy.x = this.x;
            newCopy.y = this.y;
            return newCopy;
        }

    }
    class Chap0602
    {
        static void Main(string[] args)
        {
            TestCopy a = new TestCopy();
            a.x = 50;
            a.y = 99;
            TestCopy b = a; // shallow copy (얕은 복사)
            //얕은 복사 결과 확인 
            b.x = -9; // a.x에도 -9 입력
            Console.WriteLine("{0} /  {1} ", a.x, a.y);
            Console.WriteLine("{0} /  {1} ", b.x, b.y);

            TestCopy c = new TestCopy();
            c.x = 55;
            c.y = 3;
            TestCopy d = c.HardCopy(); //deep copy : d
            d.x = -99; // d.x==-99,  c.x==55
            d.y = 77;
            Console.WriteLine("{0} {1}", c.x, c.y);
            Console.WriteLine("{0} {1}", d.x, d.y);
        }
    }
}
