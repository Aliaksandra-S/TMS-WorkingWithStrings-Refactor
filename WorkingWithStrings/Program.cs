using WorkingWithStrings;
using Microsoft.Extensions.Configuration;
using WorkingWithStrings.InputProviders;
using WorkingWithStrings.OutputProviders;

var config = new ConfigurationBuilder()
            .AddJsonFile(@"D:\CS\WorkingWithStrings-refactor\WorkingWithStrings\appsettings.json")
            .Build();


var textSection = config.GetSection("TextInput");
var textSource = ConfigurationReader.GetInputSource(textSection);
IInputProvider inputTextProvider = textSource switch
{
    "Console" => new ConsoleInputProvider(),
    "File" => new FileInputProvider(ConfigurationReader.GetInputFilePath(textSection)),
    _ => throw new ArgumentException()
};

var commandSection = config.GetSection("CommandInput");
var commandSource = ConfigurationReader.GetInputSource(commandSection);
IInputProvider inputCommandProvider = commandSource switch
{
    "Console" => new ConsoleInputProvider(),
    "File" => new FileInputProvider(ConfigurationReader.GetInputFilePath(commandSection)),
    _ => throw new ArgumentException()
};

var outputSection = config.GetSection("TextOutput");
var outputSource = ConfigurationReader.GetOutputSource(outputSection);
IOutputProvider outputProvider = outputSource switch
{
    "Console" => new ConsoleOutputProvider(),
    "File" => new FileOutputProvider(ConfigurationReader.GetOutputFilePath(outputSection)),
    _ => throw new ArgumentException()
};

Menu menu = new Menu();
menu.Start(inputTextProvider, inputCommandProvider, outputProvider);
