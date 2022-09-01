using BenchmarkDotNet.Attributes;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace BasicProgramming {
    
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class TestRunnerBenchMark {
        private const string InputFile = @"C:\Users\HP\source\repos\BasicProgramming\InputFile.txt";
        private const string OutputFile = "C:\\Users\\HP\\source\\repos\\BasicProgramming\\Countries_Prueba1.txt";
        // Se crea el nombre del archivo de salida con la fecha actual, formato: "Countries 2008-Apr-08"
        //string OutputFile = string.Format($"{PathFile}\\Countries {date.ToString("yyyy-MMM-dd", CultureInfo.GetCultureInfo("en-US"))}.txt");
        [Benchmark]
        public void StreamReaderWriterString() {
            Program.GreetCountries(InputFile, OutputFile);
        
        }        
    }
}
