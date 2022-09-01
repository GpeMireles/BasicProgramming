using BenchmarkDotNet.Running;
using System;
using System.IO;
using System.Globalization;

namespace BasicProgramming {
    public class Program {
        static void Main(string[] args) {
            //BenchmarkRunner.Run<TestRunnerBenchMark>();
            
            // 1. Conceptos Generales
            string InputFile = @"C:\Users\HP\source\repos\BasicProgramming\InputFile.txt";
            string PathFile = "C:\\Users\\HP\\source\\repos\\BasicProgramming";
            DateTime date = DateTime.Now;
            // Se crea el nombre del archivo de salida con la fecha actual, formato: "Countries 2008-Apr-08"
            string OutputFile = string.Format($"{PathFile}\\Countries {date.ToString("yyyy-MMM-dd", CultureInfo.GetCultureInfo("en-US"))}.txt");

            GreetCountries(InputFile, OutputFile);


            Console.WriteLine($"File Created, or Updated, path -> {OutputFile}");

            // 2. Progrmación Orientada a Objetos
            Laptop myLaptop = new Laptop(false, true);
            myLaptop.Connect();
            myLaptop.OnOff();
            myLaptop.Connect();

            // 3. Manejo de Excepciones
            try {
                ThrowFail.Fail();
            }
            catch(ErrorException e) {
                Console.WriteLine(e.Message);
            }
            
        }
        /// <summary>
        /// Copia las mismas lineas de texto en el archivo de salida pero con el formato: 
        /// ‘Saludos hasta XXXX!’ donde XXXX es una línea del archivo de entrada.
        /// </summary>
        /// <param name="inputFile">la ruta al archivo entrada countries.txt</param>
        /// <param name="outputFile">nuevo archivo de salida</param>
        static public void GreetCountries(string inputFile, string outputFile) {
            // Manejo de errores en la lectura y escritura del fichero
            try {
                using(StreamWriter writer = new StreamWriter(outputFile))
                using(StreamReader reader = new StreamReader(inputFile)) {
                    while(!reader.EndOfStream) {
                        writer.WriteLine($"Saldos hasta {reader.ReadLine()}!");
                        // int x = Int32.Parse(line); // Línea de prueba para excepcion diferente a FileNotFoundException
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