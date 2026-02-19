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

    #region array question2


namespace Part2_Matrix
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[,] grades = new int[3, 4];

                // Read Grades
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"\nEnter grades for Student {i + 1}:");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Subject {j + 1}: ");
                        grades[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                double overallSum = 0;

                // Calculate Averages
                for (int i = 0; i < 3; i++)
                {
                    int studentSum = 0;

                    for (int j = 0; j < 4; j++)
                    {
                        studentSum += grades[i, j];
                    }

                    double studentAvg = (double)studentSum / 4;
                    overallSum += studentSum;

                    Console.WriteLine($"Average of Student {i + 1} = {studentAvg}");
                }

                double classAverage = overallSum / (3 * 4);
                Console.WriteLine($"\nOverall Class Average = {classAverage}");
            }
        }
    }

    #endregion

    #region function question1

  

namespace Part3_Calculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Enter operation (+, -, *, /): ");
                char op = char.Parse(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = Add(num1, num2);
                        break;

                    case '-':
                        result = Subtract(num1, num2);
                        break;

                    case '*':
                        result = Multiply(num1, num2);
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            return;
                        }
                        result = Divide(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Invalid operation!");
                        return;
                }

                Console.WriteLine($"Result = {result}");
            }

            static double Add(double a, double b) => a + b;
            static double Subtract(double a, double b) => a - b;
            static double Multiply(double a, double b) => a * b;
            static double Divide(double a, double b) => a / b;
        }
    }

    #endregion

    #region function question2

  

namespace Part3_Circle
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine());

                double area, circumference;

                CalculateCircle(radius, out area, out circumference);

                Console.WriteLine($"Area = {area}");
                Console.WriteLine($"Circumference = {circumference}");
            }

            static void CalculateCircle(double radius, out double area, out double circumference)
            {
                area = Math.PI * radius * radius;
                circumference = 2 * Math.PI * radius;
            }
        }
    }

    #endregion

    #region project


namespace StudentGradeManager
    {
        enum Grade
        {
            A, B, C, D, F
        }

        class Program
        {
            static void Main(string[] args)
            {
                int[] scores = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Enter score for Student {i + 1}: ");
                    scores[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\n--- Report ---");

                for (int i = 0; i < 5; i++)
                {
                    Grade grade = GetGrade(scores[i]);
                    Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {grade}");
                }

                double average = CalculateAverage(scores);
                GetMinMax(scores, out int min, out int max);

                Console.WriteLine($"\nAverage: {average}");
                Console.WriteLine($"Highest Score: {max}");
                Console.WriteLine($"Lowest Score:  {min}");
            }

            static Grade GetGrade(int score)
            {
                if (score >= 90) return Grade.A;
                else if (score >= 80) return Grade.B;
                else if (score >= 70) return Grade.C;
                else if (score >= 60) return Grade.D;
                else return Grade.F;
            }

            static double CalculateAverage(int[] scores)
            {
                int sum = 0;
                foreach (int s in scores)
                    sum += s;

                return (double)sum / scores.Length;
            }

            static void GetMinMax(int[] scores, out int min, out int max)
            {
                min = scores[0];
                max = scores[0];

                foreach (int s in scores)
                {
                    if (s < min) min = s;
                    if (s > max) max = s;
                }
            }
        }
    }

    #endregion
}
