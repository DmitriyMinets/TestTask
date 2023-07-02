namespace Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        var dictionarySize = Convert.ToInt32(Console.ReadLine());
        var dictionary = new string[dictionarySize];

        for (var i = 0; i < dictionarySize; i++)
        {
            dictionary[i] = Console.ReadLine();
        }

        RhymeGenerator generator = new(dictionary);

        var numberRequests = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < numberRequests; i++)
        {
            var request = Console.ReadLine();
            var answer = generator.GetWordWithMaxRhyme(request);
            Console.WriteLine(answer);
        }
    }
}