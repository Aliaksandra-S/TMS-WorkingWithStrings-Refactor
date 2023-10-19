namespace WorkingWithStrings.InputProviders;

internal class FileInputProvider : IInputProvider
{
    private readonly string _inputFileName;
    private StreamReader _reader;

    public FileInputProvider(string inputFileName)
    {
        _inputFileName = inputFileName;
        _reader = new StreamReader(inputFileName);
    }
    public string ReadCommandNumber()
    {
        var input = _reader.ReadToEnd();
        _reader.Close();
        return input;
    }

    public string ReadText()
    {
        var input = _reader.ReadToEnd();
        _reader.Close();
        return input;
    }
}
