namespace Task3;

public class RhymeGenerator
{
    private readonly string[] _dictionary;
    private string _wordWithMaxRhyme;

    public RhymeGenerator(string[] dictionary)
    {
        _dictionary = dictionary;
        _wordWithMaxRhyme = string.Empty;
    }

    public string GetWordWithMaxRhyme(string word)
    {
        FindWordWithMaxRhyme(word);

        return _wordWithMaxRhyme;
    }

    private void FindWordWithMaxRhyme(string word)
    {
        var maxRhyming = 0;

        foreach (var wordDictionary in _dictionary)
        {
            if (wordDictionary.Equals(word, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var timeMaxRhyming = 0;
            var minLengthWord = Math.Min(wordDictionary.Length, word.Length);

            for (var j = 1; j < minLengthWord; j++)
            {
                if (wordDictionary.ToLower()[^j] != word.ToLower()[^j])
                {
                    break;
                }

                timeMaxRhyming++;
            }

            if (timeMaxRhyming < maxRhyming)
            {
                continue;
            }

            maxRhyming = timeMaxRhyming;
            _wordWithMaxRhyme = wordDictionary;
        }
    }
}