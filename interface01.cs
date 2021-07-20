using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// interface, abstract
// Interface : 일종의 약속, 에러 방지 
// method, property, event, indexer만 가능
// 클래스에 상속가능, 인터페이스에도 상속가능
// 정의 부분만 표현하고 구현 부분은 상속받은 클래스에서 구현
// abstract : 추상클래스
namespace CshaprBasicChaptor07_02
{
    interface IEmployee
    {
        //int a; // 인터페이스는 필드를 포함할 수 없음
        // interface에서 선언한 항목은 반드시 상속받을 경우 사용해야함
        string getName(); //중괄호 미사용, 실행가능부분 작성 불가
        void setName(string n);
        int getCounter();
    }

    public class Employee : IEmployee
    {
        public static int numberOfEmployee; 
        //static 키워드사용 : 객체 생성없이 numberOfEmployee 사용가능
        // ex) 클래스명.필드명으로 사용 가능 
        private string name;
        private int counter;
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name; //name 변수에 변수 설정
        }
        public int getCounter()
        {
            return counter; //counter 변수 값을 반환
        }
        public Employee() // 생성자
        {
            counter = ++counter + numberOfEmployee;
            // counter에 1더한 값과 직원수를 더한 값을 다시 입력
        }
    }
    class Chap0702
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
            e1.setName(n);
            Console.WriteLine("직원 정보");
            Console.WriteLine("직원번호 : {0}", e1.getCounter());
            Console.WriteLine("직원이름 : {0}", e1.getName());
        }
    }
}
