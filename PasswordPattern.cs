namespace CruxlabTestApp;

internal class PasswordPattern
{
    private readonly char _letter;
    private readonly string _password;
    private readonly int _numberPatternStart;
    private readonly int _numberPatternEnd;

    public PasswordPattern(string fileString)
    {
        var fileStringArray = fileString.Split(" ");
        
        _letter = char.Parse(fileStringArray[0]);
        _password = fileStringArray[2];
    
        var numberPatternString = fileStringArray[1][..^1]; // cut latest symbol
        _numberPatternStart = numberPatternString[0] - '0'; // convert to char to integer
        _numberPatternEnd = numberPatternString[2] - '0';
    }

    public bool IsPasswordMatching()
    {
        return Enumerable.Range(_numberPatternStart, _numberPatternEnd - _numberPatternStart + 1).Any(numberPattern =>
        {
            var match = _password.Count(c => c == _letter);
            return match == numberPattern;
        });
    }
}