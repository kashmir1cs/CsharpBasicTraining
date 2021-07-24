using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 접근자 : Property에 접근
// set, get 이용하여 접근
// value  : set 접근자 사용시 사용되는 암묵적 매개변수 
namespace CsharpBasicChaptor08_01
{
    //class Test
    //{
    //    private int x;
    //    public int GetX() //x 값을 꺼내는 메소드
    //    {
    //        return x;
    //    }

    //    public void SetX(int input) //x 값을 지정할 때 사용하는 메소드
    //    {
    //        x = input;
    //    }

    //}

    //class Test
    //{
    //    // 실제로 저장은 "x"에 저장되지만 외부에는 "Q"라는 변수만 공개
    //    // 실제 값이 저장되고 출력되는 곳은 "x"
    //    private int x; // x라는 변수를 숨길 수 있음
    //    //접근 가능하도록 접근자 필요
    //    public int Q  // "X"라는 프로퍼티 지정
    //    {
    //        get
    //        {
    //            return x;
    //        }
    //        set
    //        {
    //            x = value;
    //        }
    //    }

        
    //}
    class Test
    {
        // 자동 구현 Property : code가 간결해짐
        // C#에서 임의적으로 변수에 저장 (ildasm에서 확인가능)

        // 실제 값이 저장되고 출력되는 곳은 "x"
        public int Q  // "X"라는 프로퍼티 지정
        {
            get;
            set;
        }


    }
    class Chap0801
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Q = 10000;             // 프로퍼티 set 접근자를 통한 값 지정
            Console.WriteLine(t1.Q);  // 프로퍼티 get 접근자를 통한 값 지정
            //t1.SetX(10000);
            //Console.WriteLine(t1.GetX());
        }
    }
}
