namespace ShoppingSample;

public class ProductShelf
{
    private List<Product> products = new List<Product>();

    public Product? this[string productName]
    {
        get
        {
            return this.products
                .Find(p => p.Name == productName);
        }
    }

    public void Stock(List<Product> products)
    {
        this.products.AddRange(products);
    }
}
