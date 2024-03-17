public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        string[] tmp = s.Split(" ");


        int min = int.Parse(tmp[0]);
        int max = 0;

        int count = 0;

        for (int i = 0; i < tmp.Length; i++)
        {
            if (int.Parse(tmp[i]) < 0)
            {
                count++;
            }
        }

        //최댓값이 -인경우 최대값을 다시 지정
        if (count == tmp.Length)
        {
            max = int.Parse(tmp[0]);
        }

        for (int i = 0; i < tmp.Length; i++)
        {
            if (min > int.Parse(tmp[i]))
            {
                min = int.Parse(tmp[i]);
            }

            if (max < int.Parse(tmp[i]))
            {
                max = int.Parse(tmp[i]);
            }
        }

        answer = min + " " + max;
        return answer;
    }
}