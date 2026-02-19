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
}
