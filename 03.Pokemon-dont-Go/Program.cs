using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int value = 0;
                if (index < 0)
                {
                    sum += numbers[0];
                    value = numbers[0];
                    int lastElement = numbers[numbers.Count - 1];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, lastElement);
                }
                else if (index > numbers.Count - 1)
                {
                    sum += numbers[numbers.Count - 1];
                    value = numbers[numbers.Count - 1];
                    int firstElement = numbers[0];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(firstElement);
                }
                else
                {
                    sum += numbers[index];
                    value = numbers[index];
                    numbers.RemoveAt(index);
                }
                increaseAndDecrease(numbers, value);
            }
            Console.WriteLine(sum);
        }
        private static void increaseAndDecrease(List<int> numbers, int value)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= value)
                {
                    numbers[i] += value;
                }
                else
                {
                    numbers[i] -= value;
                }
            }
        }
    }
}
