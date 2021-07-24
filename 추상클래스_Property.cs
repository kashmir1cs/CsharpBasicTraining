using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 추상 클래스 + 프로퍼티
namespace CshapBasicChap08_02_1
{
    class Chap0802
    {
        // 추상클래스 선언
        abstract class Shape
        { 
            // 면적 프로퍼티
            public abstract double Area { get; set; }
            
        }
        class Cube : Shape
        {
            public double side;
            public Cube(double side)//생성자
            {
                this.side = side;
            }
            public override double Area
            {
                get { return 6*side * side; }
                set { side = Math.Sqrt(value/6); } // Math 클래스의 제곱근 메소드 사용 
            }


        }
        class Square : Shape
        {
            public double side;
            // 생성자
            public Square(double side)
            {
                this.side = side;
            }
            public override double Area
            {
                get { return side * side; }
                set { side = Math.Sqrt(value); } // Math 클래스의 제곱근 메소드 사용 
            }

        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            Square s = new Square(side);
            Cube c = new Cube(side);
            // 프로퍼티를 이용하여 면적 구하기
            Console.WriteLine("정사각형의 면적 = {0}", s.Area);
            Console.WriteLine("정육면체의 면적 = {0}", c.Area);
            double area = double.Parse(Console.ReadLine());
            s.Area = area; //프로퍼티 사용
            c.Area = area; //프로퍼티 사용
            Console.WriteLine("정사각형의 변의 길이 = {0}", s.side);
            Console.WriteLine("정육면체의 변의 길이 = {0}", c.side);


        }
    }
}
