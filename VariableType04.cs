using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
  열거형 변수 : enum
  var 변수
 
 */
namespace CsharpBasicChaptor03_01
{
    class Program
    {
        //열거식의 장점 : 선택의 폭을 제한하여 에러 방지
        enum Job { Teacher, Student=55, Parents} 
        //열거식, 하위 변수가 해당 항목에서만 선택
        //숫자 지정하면 인덱싱 번호변환 가능
        static void Main(string[] args)
        {
            Console.WriteLine(Job.Parents);
            Console.WriteLine(Job.Teacher);
            Console.WriteLine(Job.Student);
            // int로 형변환시 위치가 출력
            Console.WriteLine((int)Job.Parents); //56
            Console.WriteLine((int)Job.Student); //55
            Console.WriteLine((int)Job.Teacher); //0
            // var 변수 활용
            var x = 55.7; //자동으로 형 변환 (할당하는 시점에)
            var y=9; /*?? 에러 발생, 선언과 동시에 초기화해야 에러 없음*/
            
            Console.WriteLine(x);
            // object 변수와 차이점?, var은 변수형이 바뀌면 에러발생 Cast 연산자 필요
            // object는 형 변환 필요 없음 
            object a = 3.7;
            a = 5;// double에서 int로 자동 변환
            // var 변수 강제 형변환
            var z = 9;
            z = (int)11.7; //명시적 형변환 필요
            Console.WriteLine(a); //별도의 형 변환없이도 변환가능
            // Type 알아내는 Method
            Console.WriteLine("{0} {1} {2} {3}",
                x.GetType(), y.GetType(), z.GetType(),a.GetType());



        }
    }
}
