using System;
using System.Text;

namespace Builder
{

    class Program
    {

        static void Main(string[] args)
        {
            int count = 10;
            string[] sillyStringArray = { "dog", "cow", "cat", "horse" };

            StringBuilder sb = new StringBuilder("This is a new initial string", 200);
            Console.WriteLine($"The length of the string is {sb.Length} and the capacity of sb = {sb.Capacity}");

            sb.Append("The quick brown fox");
            sb.Append("Jumped over the lazy dog");
            sb.AppendLine();

            sb.AppendFormat("He jumped over {0} times", count);
            sb.AppendLine();

            sb.Append("He also jumped over ");
            sb.AppendJoin(',', sillyStringArray);

            sb.Replace("cow", "kangaroo");
            sb.Insert(0, "Hier kom dit nou ");

            Console.WriteLine($"Now the string length is {sb.Length} and the capacity is  {sb.Capacity}");
            Console.WriteLine(sb.ToString());
        }
    }
}