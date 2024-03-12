using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers
{
    public class Day01
    {
        public string solution(string s)
        {
            /* 
               JadenCase란 모든 단어의 첫 문자가 대문자이고, 그 외의 알파벳은 소문자인 문자열입니다.
               단, 첫 문자가 알파벳이 아닐 때에는 이어지는 알파벳은 소문자로 쓰면 됩니다. (첫 번째 입출력 예 참고)
               문자열 s가 주어졌을 때, s를 JadenCase로 바꾼 문자열을 리턴하는 함수, solution을 완성해주세요.

            제한 조건
            - s는 길이 1 이상 200 이하인 문자열입니다.
            - s는 알파벳과 숫자, 공백문자(" ")로 이루어져 있습니다.
            - 숫자는 단어의 첫 문자로만 나옵니다.
            - 숫자로만 이루어진 단어는 없습니다.
            - 공백문자가 연속해서 나올 수 있습니다.
            */

            string answer = "";

            //문자열을 " "로 구분하여 담는다
            string[] tmp = s.Split(" ");

            for (int i = 0; i < tmp.Length; i++)
            {
                //문자열을 자른다.
                char[] k = tmp[i].ToCharArray();

                for (int j = 0; j < k.Length; j++)
                {
                    if (j == 0)
                    {   //첫글자만 대문자로 바꾼다
                        k[j] = char.ToUpper(k[j]);
                    }
                    else
                    {  
                        k[j] = char.ToLower(k[j]);
                    }

                }
                //문자열 k열을 이어 붙인다.
                string str = new string(k);

                if (i == 0)
                {
                    answer += str;
                }
                else
                {
                    answer += " " + str;
                }
            }

            return answer;
        }
    }
}
