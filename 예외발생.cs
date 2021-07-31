using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// throw : 예외 발생하기 (강제 발생 하기)
namespace CsharpBasicChaptor1101_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        
    }
}
