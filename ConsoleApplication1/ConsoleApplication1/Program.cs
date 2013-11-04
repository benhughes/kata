using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://projecteuler.net/problems

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList multiples = new ArrayList();
            multiples.Add(3);
            multiples.Add(5);


            Console.WriteLine(SumOfNumbersThatAreMultiplesOf(10, multiples));
            Console.WriteLine(SumOfNumbersThatAreMultiplesOf(1000, multiples));
            ;

            Console.WriteLine();
            Console.WriteLine("hi there again"); 
        }

        private static Boolean IsMultipleOf(int num, int multiple)
        {
            return num % multiple == 0 && num != 0;
        }

        private static int SumOfNumbersThatAreMultiplesOf(int lowerThan, ArrayList multiples)
        {
            int answer = 0;
            Boolean multipleOf;
            foreach (int multiple in multiples)
            {
                for (int i = 0; i < lowerThan; i++)
                {
                    multipleOf = IsMultipleOf(i, multiple);

                    if (multipleOf)
                    {
                        answer += i;
                    }
                }
            }
            return answer;
        }
    }

 
}
