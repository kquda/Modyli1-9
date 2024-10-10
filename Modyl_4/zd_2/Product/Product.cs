public class Fruit : IProduct
{
    public string Name { get; set; }

    public double PriceKg { get; set; }

    public int StockKg { get; set; }

    public Fruit(string name, double pricekg, int stockkg)
    {
        Name = name;
        PriceKg = pricekg;
        StockKg = stockkg;
    }

    public double PriceProduct()
    { return PriceKg;}

    public int RestProduct()
    { return StockKg; }
}

public class Drink : IProduct
{
    public string Name { get; set; }
    public double PriceLiter { get; set; }
    public int StockLiters { get; set; }

    public Drink(string name, double priceLiter, int stockLiters)
    {
        Name = name;
        PriceLiter = priceLiter;
        StockLiters = stockLiters;
    }

    public double PriceProduct()
    { return PriceLiter; }

    public int RestProduct()
    { return StockLiters; }
}

public class Vegetable : IProduct
{
    public string Name { get; set; }
    public double PriceKg { get; set; }
    public int StockKg { get; set; }

    public Vegetable(string name, double pricekg, int stockkg)
    {
        Name = name;
        PriceKg = pricekg;
        StockKg = stockkg;
    }

    public double PriceProduct()
    {
        return PriceKg;
    }

    public int RestProduct()
    {
        return StockKg;
    }
}