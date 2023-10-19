using Microsoft.Extensions.Configuration;

namespace WorkingWithStrings
{
    internal class ConfigurationReader
    {
        public static string GetInputSource(IConfiguration config) => config["InputSource"];

        public static string GetInputFilePath(IConfiguration config) => config["InputFilePath"];

        public static string GetOutputSource(IConfiguration config) => config["OutputSource"];

        public static string GetOutputFilePath(IConfiguration config) => config["OutputFilePath"];
    }
}
