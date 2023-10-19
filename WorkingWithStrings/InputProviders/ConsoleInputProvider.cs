namespace WorkingWithStrings.InputProviders;

internal class ConsoleInputProvider : IInputProvider
{
    public string ReadCommandNumber()
    {
        return Console.ReadLine();
    }
    public string ReadText()
    {
        return Console.ReadLine();
    }
}

