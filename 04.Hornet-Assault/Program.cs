using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            List<long> hornets = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            long power = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                if (beehives[i] < power)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= power;
                    power -= hornets[0];
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Sum() > 0)
            {
                Console.WriteLine(String.Join(" ", beehives.Where(e => e != 0)));
            }
            else
            {
                Console.WriteLine(String.Join(" ", hornets));
            }
        }
    }
}
