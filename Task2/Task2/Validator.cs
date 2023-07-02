namespace Task2;

public class Validator
{
    private const string ValidData = "abcdefghijklmnopqrstuvwxyz0123456789-_",
        Confirmation = "YES",
        Negation = "NO";
    private const int MinLength = 2,
        MaxLength = 24;
    private const char Hyphen = '-';
    private readonly string[] _userNames;
    private readonly List<string> _validationResults;
    private readonly List<string> _validUserNames;

    public Validator(string[] userNames)
    {
        _validUserNames = new List<string>();
        _validationResults = new List<string>();
        _userNames = userNames;
    }

    public void PrintResult()
    {
        AddValidUserNamesAndResultsValidation(_userNames);

        foreach (var result in _validationResults)
            Console.WriteLine(result);
        Console.WriteLine();
    }

    private void AddValidUserNamesAndResultsValidation(IReadOnlyList<string> userNames)
    {
        for (var i = 0; i < _userNames.Length; i++)
        {
            var userName = userNames[i];
            var validationResult = GetValidationResult(userName);

            if (!validationResult)
            {
                _validationResults.Add(Negation);
            }
            else
            {
                if (_validUserNames.Contains(userName))
                {
                    _validationResults.Add(Negation);
                }
                else
                {
                    _validationResults.Add(Confirmation);
                    _validUserNames.Add(userName);
                }
            }
        }
    }

    private static bool GetValidationResult(string userName)
    {
        var userNameLength = userName.Length;
        var lengthValidation = userNameLength < MinLength || userNameLength > MaxLength;

        if (lengthValidation)
        {
            return false;
        }

        return userName[0] != Hyphen && CheckSymbolForValidity(userName);
    }

    private static bool CheckSymbolForValidity(string userName)
    {
        foreach (var symbol in  userName)
        {
            if (!ValidData.Contains(symbol))
            {
                return false;
            }
        }

        return true;
    }
}