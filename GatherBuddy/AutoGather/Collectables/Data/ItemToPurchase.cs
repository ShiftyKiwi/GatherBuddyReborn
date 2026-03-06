namespace GatherBuddy.AutoGather.Collectables.Data;

public class ItemToPurchase
{
    public ScripShopItem Item { get; set; } = null!;
    public string Name => Item.Name;
    public int Quantity { get; set; }
}
