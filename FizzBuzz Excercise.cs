namespace azarias
{
    public static class Solution
    {

        public string FizzBuzz(int num)
        {
            var answer = "";

            if (num % 3 == 0)
            {
                answer = "fizz";
            }

            if (num % 5 == 0)
            {
                answer = "buzz";
            }

            if (num % 3 == 0 && num % 5 == 0)
            {
                answer = "fizzbuzz";
            }

            return answer;
        }

            
    }

}