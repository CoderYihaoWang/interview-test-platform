public class ItemA : Item
{
    public ItemA(): base("A", 50.0)
    {
    }

    public override void Rule()
    {
        if (Count % 3 == 0)
        {
            Total -= 20;
        }
    }
}