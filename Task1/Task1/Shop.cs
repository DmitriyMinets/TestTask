namespace Task1;

public class Shop
{
    private const int QuantityProductForDiscounts = 3;
    private Dictionary<int, int> _productsAndQuantityProducts;

    public void ShowTotalAmount(int[] products)
    {
        Console.WriteLine(GetTotalAmount(products));
    }

    private int GetTotalAmount(IEnumerable<int> products)
    {
        var totalAmount = 0;
        var productsAndQuantityProducts = GetProductsAndQuantityProducts(products);

        foreach (var (priceProduct, quantityProduct) in productsAndQuantityProducts)
            totalAmount += (quantityProduct - quantityProduct / QuantityProductForDiscounts) * priceProduct;

        return totalAmount;
    }

    private Dictionary<int, int> GetProductsAndQuantityProducts(IEnumerable<int> products)
    {
        _productsAndQuantityProducts = new Dictionary<int, int>();

        foreach (var product in products)
        {
            _productsAndQuantityProducts.TryAdd(product, 0);
            _productsAndQuantityProducts[product]++;
        }

        return _productsAndQuantityProducts;
    }
}