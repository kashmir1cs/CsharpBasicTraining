using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 컬렉션 개체 실습하기
namespace CsharpBasicChaptor0804_01
{
    class Chap0804_01
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            // 반복문 + add를 통해 추가 가능
            for (int i=0;i<3;i++)
            {
                l.Add(i);
                // arraylist에 변수 추가 
                
            }
            foreach (int k in l) Console.WriteLine(k);
            l.Remove(1); //특정 위치 값 제거
            foreach (int k in l) Console.WriteLine(k);
            l.Insert(1, -9);
            foreach (int k in l) Console.WriteLine(k);
            Console.WriteLine("l.Count 실행 결과 : {0} ",l.Count);
            /*ArrayList l = new ArrayList();
            // 반복문 + add를 통해 추가 가능
            for (int i = 0; i < 20000; i++)
            {
                if (i % 32 == 0 && i != 0) //i가 7의 배수면
                {
                    l.Add(i);
                }
                // arraylist에 변수 추가 

            }
            foreach (int k in l) Console.WriteLine("32의 배수는 {0}", k);*/

            Stack s = new Stack(); // Last In, First Out
            // 집어넣을때 Push, 뺄때는 Pop
            Console.WriteLine("Stack 연습 ");

            s.Push(-9); // Stack에 삽입
            s.Push(3);
            s.Push(10);
            while (s.Count != 0) Console.WriteLine(s.Pop()); //Stack에서 원소를 꺼낸다
            
        }
    }
}
