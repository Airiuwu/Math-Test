using System;

namespace Math_Test
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int counter = 0;
            int total = 0;
            var completed = false;
            float solution = 0;
            int operators = random.Next(1, 5);
            string oper = "";
            string question = "";
            do
            {
                float num = random.Next(100);
                float num2 = random.Next(100);
                switch (operators)
                {
                    case 1:
                        oper = "+";
                        question = $"What is {num} {oper} {num2}?";
                        solution = num + num2;
                        break;
                    case 2:
                        oper = "-";
                        question = $"What is {num} {oper} {num2}?";
                        solution = num - num2;
                        break;
                    case 3:
                        oper = "*";
                        question = $"What is {num} {oper} {num2}?";
                        solution = num * num2;
                        break;
                    case 4:
                        oper = "÷";
                        question = $"What is {num} {oper} {num2}? (Decimal point goes to 2 (0.00))";
                        float number = num / num2;
                        solution = (float)System.Math.Round(number, 2);
                        break;
                }

                if (total == 0)
                {
                    Console.WriteLine(question);

                }
                else
                {
                    Console.WriteLine($"\n{question}");

                }
                float answer = Convert.ToSingle(Console.ReadLine());
                if (answer == solution)
                {
                    Console.Clear();
                    total++;
                    counter++;
                    operators = random.Next(1, 5);
                    Console.WriteLine($"Correct! {num} {oper} {num2} is {solution}!\nScore => {counter}/{total}");
                    if (counter == 10)
                    {
                        completed = true;
                    }
                }
                else
                {
                    Console.Clear();
                    total++;
                    operators = random.Next(1, 5);
                    Console.WriteLine($"Not quite.\nScore => {counter}/{total}");
                }
            } while (!completed);
            if (completed)
            {
                Console.Clear();
                Console.WriteLine($"Congratulations, you completed the math test!\nScore => {counter}/{total}");
            }

        }
    }
}
