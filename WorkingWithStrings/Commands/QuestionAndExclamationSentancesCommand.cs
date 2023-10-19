using System.Text;

namespace WorkingWithStrings.Commands;
internal class QuestionAndExclamationSentancesCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;

    public QuestionAndExclamationSentancesCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider)
        : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }
    public override string Description => "Вывести на экран сначала вопросительные, а затем восклицательные предложения.";

    public override string GetResult()
    {
        var builder = new StringBuilder();

        builder.Append("\nВопросительные:");
        foreach (var sentance in _stringAnalyzer.QuestionSentences())
            builder.Append(sentance);

        builder.Append("\nВосклицательные:");
        foreach (var sentance in _stringAnalyzer.ExclamationSentences())
            builder.Append(sentance);

        return builder.ToString();
    }
}


