public class FizzBuzz
{
    public static bool isMultipleOf3(int number)
    {
        int sum = 0;

        for (int i = 0; i < number.ToString().Length; i++)
        {
            var charNumber = number.ToString().ElementAt(i);
            sum += int.Parse(charNumber.ToString());
        }

        return sum % 3 == 0;
    }

    public static void fizzBuzz(int n)
    {
        for (int i = 205; i <= n; i++)
        {
            if (isMultipleOf3(i))
            {
                if (i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else
                    Console.WriteLine("Fizz");

                continue;
            }

            if (i % 5 == 0 && !isMultipleOf3(i))
            {
                Console.WriteLine("Buzz");
                continue;
            }

            Console.WriteLine(i);
        }
    }
}