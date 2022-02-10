using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata13_HighestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            HigherNumber number = new HigherNumber();
            number.existsHigher(new int[] { 5, 3, 15, 22, 4 }, 10, true); //true
            number.existsHigher(new int[] {1, 2, 3, 4, 5}, 8, false); // false

            number.existsHigher(new int[] {4, 3, 3, 3, 2, 2, 2}, 4, true); // true
            number.existsHigher(new int[] {-10, -99, -57, -4}, -4, true); // true

            number.existsHigher(new int[] { 5 }, 5, true); // true

            number.existsHigher(new int[] {99, 99}, 99, true); // true

            number.existsHigher(new int[0], 5, false); // false

            Console.ReadLine();
        }

    }

    public class HigherNumber
    {
        public bool existsHigher(int[] numbers, int n, bool expectedOutcome)
        {
            bool result = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= n)
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine("expectedOutcome: " + expectedOutcome + " actual outcome: " + result + " final outcome: " + (expectedOutcome == result));
            return result;
        }
    }
    
}
