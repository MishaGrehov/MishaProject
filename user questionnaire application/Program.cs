using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_questionnaire_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your name:");
            string name = Console.ReadLine();
            Console.Write("Please, enter your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name  +" " +   surname + "!");
            Console.Write("Let me ask one more question, how old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("So this is information about you:");
            Console.WriteLine(name + " " + surname + "," +" " + age + " " + "years old");
        }
    }
}
