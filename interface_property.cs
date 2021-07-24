using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// interface+ property활용
// property활용 하여 코드 간결하게 작성 가능
namespace CshaprBasicChaptor08_02
{
    interface IEmployee
    {
        //int a; // 인터페이스는 필드를 포함할 수 없음
        // interface에서 선언한 항목은 반드시 상속받을 경우 사용해야함
        string Name //읽기 쓰기 모두 가능한 프로퍼티
        {
            get;
            set;
        }
        int Counter
        {
            get;
        }

    }

    public class Employee : IEmployee
    {
        public static int numberOfEmployee;
        //static 키워드사용 : 객체 생성없이 numberOfEmployee 사용가능
        // ex) 클래스명.필드명으로 사용 가능 
        private string name;
        private int counter;
        public Employee() // 생성자
        {
            counter = ++counter + numberOfEmployee;
            // counter에 1더한 값과 직원수를 더한 값을 다시 입력
        }
        public string Name //읽기 쓰기 모두 가능한 프로퍼티
        {
            get{ return name; }
            set { name = value; }
        }
        public int Counter
        {
            get { return counter; }
        }
    }
    class Chap0802
    {
        // Interface 실습

        static void Main(string[] args)
        {
            string n;
            Console.Write("직원 수 입력: ");
            // Employee.numberOfEmployee 객체생성 안해도 되는 이유 
            // numberOfEmployee를 static 키워드로 생성
            Employee.numberOfEmployee = int.Parse(Console.ReadLine()); //정수형으로 변환

            Employee e1 = new Employee(); // 직원 객체 생성
            Console.Write("new guy names");
            n = Console.ReadLine();
            e1.Name=n; // Name에 저장
            Console.WriteLine("직원 정보");
            Console.WriteLine("직원번호 : {0}", e1.Counter); //property로 접근
            Console.WriteLine("직원이름 : {0}", e1.Name); // property로 접근
        }
    }
}
