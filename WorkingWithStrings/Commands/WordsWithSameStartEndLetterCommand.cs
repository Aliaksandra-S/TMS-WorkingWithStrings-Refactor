using System.Text;

namespace WorkingWithStrings.Commands;

internal class WordsWithSameStartEndLetterCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;

    public WordsWithSameStartEndLetterCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider)
        : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }

    public override string Description => "Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву";

    public override string GetResult()
    {
        var builder = new StringBuilder();
        foreach (var w in _stringAnalyzer.FindWordsWithSameStartEndLetter())
            builder.Append(w);

        return builder.ToString();
    }
}

