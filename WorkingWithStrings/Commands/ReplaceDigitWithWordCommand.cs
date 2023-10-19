namespace WorkingWithStrings.Commands;

internal class ReplaceDigitWithWordCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;

    public ReplaceDigitWithWordCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider)
        : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }
    public override string Description => "Заменить все цифры в тексте на слова";

    public override string GetResult()
    {
        return _stringAnalyzer.ReplaceNumbers();
    }
}

