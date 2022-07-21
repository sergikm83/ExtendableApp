using System;
using System.Reflection;
using System.IO;
using CommonSnappableTypes;

namespace MyExtendableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadSnapin();
        }
        static void LoadSnapin()
        {
            Console.WriteLine("Select assembly:\n");
            string listOfAssembly = string.Format($"1 -> {Utilities.CommonSnappableTypesDLL}\n" +
                $"2 -> {Utilities.CSharpSnapInDLL}\n" +
                $"3 -> {Utilities.VbSnapInDLL}\n");
            Console.WriteLine(listOfAssembly);
            Console.Write("enter assembly number: ");
            string asmChoice= Console.ReadLine();
            switch(asmChoice)
            {
                case "1":
                    ;
                    break;
                case "2":
                    ;
                    break;
                case "3":
                    ;
                    break;
                default:
                    Console.WriteLine("Oops. Wrong choice");
                    break;
            }
        }
    }
}
