using System.Xml;

namespace SyntaxSugarDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicit typing
            int number = 10;
            string name = "test";
            int num;

            //Inferred typing
            var thing = true;
            var otherNumber = 12.0m;

            //inline if (ternary)

            var age = 4;
            
            Console.WriteLine((age >= 18) ? "You're an adult" : (age < 5) ? "You are a baby" : "You're a minor");

            //String interpolation vs Concatenation
            var middleName = 'S';
            Console.WriteLine($"Seth {middleName} Bowman");
            Console.WriteLine("Seth" + " " + middleName + " " + "Bowman");
        }
    }
}