using System;
using System.IO;
using System.Globalization;

namespace BasicProgramming {
    internal class Program {
        static void Main(string[] args) {
            //string InputFile = @"C:\Users\HP\source\repos\BasicProgramming\InputFile.txt";
            string InputFile = @"C:\Users\HP\source\repos\BasicProgramming\Auxiliar.txt";
            string PathFile = "C:\\Users\\HP\\source\\repos\\BasicProgramming";
            DateTime date = DateTime.Now;
            string OutputFile = string.Format($"{PathFile}\\Countries {date.ToString("yyyy-MMM-dd", CultureInfo.GetCultureInfo("en-US"))}.txt");
            GreetCountries(InputFile, OutputFile);
            Console.WriteLine(OutputFile);
    }

        static private void GreetCountries(string inputFile, string outputFile) {
            using(StreamWriter writer = new StreamWriter(outputFile))
            using(StreamReader reader = new StreamReader(inputFile)) {
                string line;
                while((line = reader.ReadLine()) != null) {
                    writer.WriteLine($"Saldos hasta {line}!");
                }
            }
        }
    }
}
