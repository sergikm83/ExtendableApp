using System;
namespace MyExtendableApp
{
    // вспомогательный класс для упрощения работы
    // с путями и именами файлов.
    // Создан дополнительно и не входит в состав кода,
    // описанного в книге, т.к. в качестве проекта MyExtedableApp
    // была выбрана платформа NET.Core 5.0 вместо предлагаемой
    // в книге .NET Framework версии 4.x (подключение пространтва
    // имен System.Windows.Form)
    
    public static class Utilities
    {
        // Название папок с проектами решения ExtandableApp
        public static readonly string MyExtendableAppDirectory = "MyExtendableApp";
        public static readonly string CommonSnappableTypesDirectory = "CommonSnappableTypes";
        public static readonly string CSharpSnapInDirectory = "CSharpSnapIn";
        public static readonly string VbSnapInDirectory = "VbSnapIn";
        // вспомогательный отрезок пути для всех проектов при компиляции
        public static readonly string ProjectBinDebugNetDirectory = @"\bin\Debug\net5.0\";
        // имена файлов библиотек классов решения ExtedableApp
        public static readonly string CommonSnappableTypesDLL = "CommonSnappableTypes.dll";
        public static readonly string CSharpSnapInDLL = "CSharpSnapIn.dll";
        public static readonly string VbSnapInDLL = "VbSnapIn.dll";
        // корневой каталог решения ExtandableApp
        public static readonly string RootSolutionPath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf(MyExtendableAppDirectory));
    }
}
