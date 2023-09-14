//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
            Console.WriteLine("Введите начало диапазона M:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона N:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateSumInRange(m, n);

            Console.WriteLine($"Сумма натуральных чисел в диапазоне от {m} до {n} равна {sum}");

        static int CalculateSumInRange(int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }