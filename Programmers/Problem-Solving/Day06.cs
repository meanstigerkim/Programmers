using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers.Problem_Solving
{
    public class Day06
    {
        // 주몽의 명령 
        // 갑옷을 만드는데 각 재료들은 각각의 고유한 번호가 있고
        // 감옷 2개 의 재료로 만드는 2가지 재료의 고유한 번호를 합쳐서 M (1<= N <= 15,000)개의
        // 재료와 M이 주어졌을 떄 몇개의 갑옷을 만들 수 있는지를 구하는 프로그램을 구하시오
        public static void Main(string[] args) 
        {
            int N = 6; // 재료의 개수
            int M = 9; // 갑옷이 완성되는 번호의 합
            List<int> numbers = new List<int>(new int[] { 2, 7, 4, 1, 5, 3 });

            numbers.Sort(); // 정렬

            int count = 0;
            int i = 0;
            int j = N - 1;
            while (i<j)
            {
                if (numbers[i] + numbers[j] < M)
                {
                    i++;
                }
                else if (numbers[i] + numbers[j] > M)
                {
                    j--;
                }
                else 
                {
                    count++;
                    i++;
                }
            }
        }
   
    }
}
