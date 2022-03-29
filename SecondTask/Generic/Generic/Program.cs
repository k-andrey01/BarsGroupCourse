using System;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\C#\\repos\\BarsGroupCourse\\SecondTask\\Generic\\Generic\\TextFile.txt";

            LocalFileLogger<string> lflString = new LocalFileLogger<string>(path);
            lflString.LogInfo("Info message from string!");
            lflString.LogWarning("Warning message from string!");
            lflString.LogError("Error message from string", new Exception());

            LocalFileLogger<int> lflInt = new LocalFileLogger<int>(path);
            lflString.LogInfo("Info message from int!");
            lflString.LogWarning("Warning message from int!");
            lflString.LogError("Error message from int", new Exception());

            LocalFileLogger<double[]> lflDoubleArray = new LocalFileLogger<double[]>(path);
            lflString.LogInfo("Info message from double array!");
            lflString.LogWarning("Warning message from double array!");
            lflString.LogError("Error message from double array", new Exception());
        }
    }
}
