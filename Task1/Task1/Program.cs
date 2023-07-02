namespace Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Shop shop = new();
        var quantityInputData = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < quantityInputData; i++)
        {
            var quantityPurchaseItems = Convert.ToInt32(Console.ReadLine());
            var temporaryVariable = Console.ReadLine()?.Split(' ');
            var products = new int[quantityPurchaseItems];

            for (var j = 0; j < quantityPurchaseItems; j++) 
                products[j] = Convert.ToInt32(temporaryVariable?[j]);

            shop.ShowTotalAmount(products);
        }
    }
}