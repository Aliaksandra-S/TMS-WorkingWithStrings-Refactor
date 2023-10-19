using System.Text;

namespace WorkingWithStrings.Commands;
internal class SentancesWithoutCommaCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;

    public SentancesWithoutCommaCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider)
        : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }

    public override string Description => "Вывести на экран только предложения, не содержащие запятых.";

    public override string GetResult()
    {
        var builder = new StringBuilder();
        foreach (var s in _stringAnalyzer.SentencesWithoutCommas())
            builder.Append(s);

        return builder.ToString();
    }
}

