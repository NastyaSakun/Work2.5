using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2._5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] chisla = { 1, 2, 3 };
            var str = "nastya sakun"; 

            (int, int, int, string) Check(int[] number, string stroka) 
            {
                for (var j = 0; j < number.Length - 1; j++) 
                    if (number[j] > number[j + 1])
                    {
                        var temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                    }

                var sum = 0;
                foreach (var i in number) sum += i; 

                var result = (number[0], number[number.Length - 1], sum, str[0].ToString()); 
                return result;
            }

            Console.WriteLine("Answer - {0}", Check(chisla, str));
        }
    }
}
