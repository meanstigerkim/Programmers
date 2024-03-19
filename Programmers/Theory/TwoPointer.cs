using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers.Theory
{
    public class TwoPointer
    {
        //연속된 수의 합을 구하는 방법
        // sum = 1
        // sum > N : sum - start_index; start_index
        // sum == N: end_index++; sum = sum + end_index; count++;

        public static void Main(string[] args)
        {
    
            int N = int.Parse(Console.ReadLine());

            int count = 1;
            int Start_Index = 1;
            int End_Index = 1;
            int sum = 1;
            while (End_Index != N) 
            {
                if (sum == N)
                {
                    End_Index++;
                    sum = sum + End_Index;
                    count++;
                }
                else if (sum > N)
                {
                    sum = sum - Start_Index;
                    Start_Index++;
                }
                else 
                {
                    End_Index++;
                    sum = sum + End_Index;
                }
            }

            Console.WriteLine(count);

        }

    }
}
