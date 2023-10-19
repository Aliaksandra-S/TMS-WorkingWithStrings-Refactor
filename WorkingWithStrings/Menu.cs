using WorkingWithStrings.Commands;
using WorkingWithStrings.InputProviders;
using WorkingWithStrings.OutputProviders;

namespace WorkingWithStrings;

internal class Menu
{
    public void Start(IInputProvider inputTextProvider, IInputProvider inputCommandProvider, IOutputProvider outputProvider)
    { 
        var stringAnalyzer = new StringAnalyzer(inputTextProvider);

        var commands = new List<ICommand>
        {
            new ExitCommand(),
            new MaxDigitWordsCommand(stringAnalyzer, outputProvider),
            new LongestWordCount(stringAnalyzer, outputProvider),
            new ReplaceDigitWithWordCommand(stringAnalyzer, outputProvider),
            new QuestionAndExclamationSentancesCommand(stringAnalyzer, outputProvider),
            new SentancesWithoutCommaCommand(stringAnalyzer, outputProvider),
            new WordsWithSameStartEndLetterCommand(stringAnalyzer, outputProvider),
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введите операцию");

            for (var i = 0; i < commands.Count; i++)
            {
                Console.WriteLine($"{i} => {commands[i].Description}");
            }

            var inputCommand = inputCommandProvider.ReadCommandNumber();

            Console.WriteLine($"Введено: {inputCommand}\n");
            
            if(int.TryParse(inputCommand, out var parsed) && parsed < commands.Count)
            {
                var command = commands[int.Parse(inputCommand)];
                command.Execute();
            }
            else
            {
                Console.WriteLine($"Доступны только циферки от 0 до {commands.Count - 1}, ещё раз такую дич напишешь, я тебе винду снесу! ");
                inputCommand = inputCommandProvider.ReadCommandNumber();
            }
            Console.ReadKey();
        }
    }
}
