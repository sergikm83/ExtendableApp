﻿using System;
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
        private static bool LoadExternalModule(string path)
        {
            bool foundSnapIn = false;
            Assembly theSnapInAsm = null;
            try
            {
                // Динамически загрузить выбранную сборку.
                theSnapInAsm = Assembly.LoadFrom(path);
            }
            catch (Exception ex)
            {
                // Ошибка при загрузке оснастки.
                Console.WriteLine($"An error occured loading the snapin: {ex.Message}");
                return foundSnapIn;
            }
            // Получить все совместимые с IAppFunctionality классы в сборке.
            var theClassTypes = from t in theSnapInAsm.GetTypes();
            foreach(Type t in theClassTypes)
            {
                foundSnapIn = true;
                // Использовать позднее связывание для создания экземпляра типа.
                IAppFunctionality itfApp = (IAppFunctionality)theSnapInAsm.CreateInstance(t.FullName, true);
                itfApp?.DoIt();
                // Отобразить информацию о компании.
            }
            return foundSnapIn;
        }
    }
}
