public abstract class Item
{
    public string Name { get; protected set; }
    public double Total { get; protected set; }
    public int Count { get; protected set; }
    public double Price { get; protected set; }

    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // override this to make discounts
    public abstract void Rule();

    public void Add()
    {
        Total += Price;
        Count += 1;
        Rule();
    }

}