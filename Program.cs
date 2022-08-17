using System;
using System.IO;
using System.Globalization;

namespace BasicProgramming {
    internal class Program {
        static void Main(string[] args) {
            /*
            string InputFile = @"C:\Users\HP\source\repos\BasicProgramming\InputFile.txt";
            string PathFile = "C:\\Users\\HP\\source\\repos\\BasicProgramming";
            DateTime date = DateTime.Now;
            string OutputFile = string.Format($"{PathFile}\\Countries {date.ToString("yyyy-MMM-dd", CultureInfo.GetCultureInfo("en-US"))}.txt");
            GreetCountries(InputFile, OutputFile);
            Console.WriteLine($"File Created, or Updated, path -> {OutputFile}");
            */
            Laptop myLaptop = new Laptop(false, true);
            myLaptop.Connect();
            myLaptop.OnOff();
            myLaptop.Connect();

            try {
                ThrowFail.Fail();
            }
            catch(ErrorException e) {
                Console.WriteLine(e.Message);
            }

        }

        static private void GreetCountries(string inputFile, string outputFile) {
            try {
                using(StreamWriter writer = new StreamWriter(outputFile))
                using(StreamReader reader = new StreamReader(inputFile)) {
                    string line;
                    while((line = reader.ReadLine()) != null) {
                        writer.WriteLine($"Saldos hasta {line}!");
                        // int x = Int32.Parse(line);
                    }
                }
            }
            catch(FileNotFoundException e) {
                Console.WriteLine(e.Message);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}