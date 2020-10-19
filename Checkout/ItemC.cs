using System;

public class ItemC : Item
{
    public ItemC() : base("C", 20.0)
    {
    }

    public override void Rule()
    {
        if (Count > 6)
        {
            throw new InvalidOperationException("Cannot add more than 6 items of D");
        }
    }
}