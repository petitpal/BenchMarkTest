using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Validators;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Columns;
using System.Linq;

namespace MyBenchmarks
{

    public class Program
    {
        public static void Main(string[] args)
        {
                var config = new ManualConfig()
                    //.WithOptions(ConfigOptions.DisableOptimizationsValidator)
                    .AddValidator(JitOptimizationsValidator.DontFailOnError)
                    .AddLogger(ConsoleLogger.Default)
                    .AddExporter(DefaultConfig.Instance.GetExporters().ToArray())
                    .AddColumnProvider(DefaultColumnProviders.Instance);

                BenchmarkRunner.Run<Sleeps>(config);
        }
    }
}