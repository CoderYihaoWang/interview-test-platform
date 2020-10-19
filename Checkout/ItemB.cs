public class ItemB : Item
{
    public ItemB() : base("B", 30.0)
    {
    }

    public override void Rule()
    {
        if (Count % 2 == 0)
        {
            Total -= 15;
        }
    }
}