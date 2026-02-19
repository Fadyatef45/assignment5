namespace assignment5
{
    #region enums question1

    internal class Program
    {
        enum DayOfWeek
        {
            Saturday = 1,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }


        static void Main(string[] args)
        {
            Console.Write("Enter a day number (1-7): ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 7)
            {
                DayOfWeek day = (DayOfWeek)number;
                Console.WriteLine($"Day: {day}");

                switch (day)
                {
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        Console.WriteLine("It's the Weekend");
                        break;

                    default:
                        Console.WriteLine("It's a Workday");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid day number!");
            }
        }
    }

    #endregion

    #region array question1

 namespace Part2_Arrays
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter array size: ");
                int size = int.Parse(Console.ReadLine());

                int[] numbers = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter element [{i}]: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;
                int max = numbers[0];
                int min = numbers[0];

                for (int i = 0; i < size; i++)
                {
                    sum += numbers[i];

                    if (numbers[i] > max)
                        max = numbers[i];

                    if (numbers[i] < min)
                        min = numbers[i];
                }

                double average = (double)sum / size;

                Console.WriteLine($"\nSum     = {sum}");
                Console.WriteLine($"Average = {average}");
                Console.WriteLine($"Max     = {max}");
                Console.WriteLine($"Min     = {min}");

                Console.Write("Reverse = ");
                for (int i = size - 1; i >= 0; i--)
                {
                    Console.Write(numbers[i]);
                    if (i > 0)
                        Console.Write(", ");
                }
            }
        }
    }


    #endregion
}
