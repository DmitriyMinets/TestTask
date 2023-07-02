namespace Task2;

internal class Program
{
    private static void Main()
    {
        var inputDataSets = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < inputDataSets; i++)
        {
            var quantityAttempts = Convert.ToInt32(Console.ReadLine());
            var userNames = new string[quantityAttempts];

            for (var j = 0; j < quantityAttempts; j++)
            {
                userNames[j] = Console.ReadLine().ToLower();
            }

            Validator validator = new(userNames);
            validator.PrintResult();
        }
    }
}