using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    internal class Day05
    {
        public class Solution
        {
            public int solution(int n)
            {

                int answer = 0;
                answer = Fibo(n);

                return answer;
            }

            private static int Fibo(int n)
            {

                if (n < 2)
                {
                    return n;
                }
                int k = 0;

                k = (Fibo(n - 2) + Fibo(n - 1)) % 1234567;

                return k;
            }
        }
    }
}
