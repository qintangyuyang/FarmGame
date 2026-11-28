public enum ItemType
{
    /// <summary>种子</summary>
    Seed,
    /// <summary>商品</summary>
    Commodity,
    /// <summary>家具</summary>
    Furniture,
    /// <summary>锄地工具</summary>
    HoeTool,
    /// <summary>砍树工具</summary>
    ChopTool,
    /// <summary>砸石头工具</summary>
    BreakTool,
    /// <summary>割草工具</summary>
    ReapTool,
    /// <summary>浇水工具</summary>
    WaterTool,
    /// <summary>收割工具</summary>
    CollectTool,
    /// <summary>可以被割的杂草</summary>
    ReapableScenery,
}

public enum SlotType
{
    /// <summary>背包</summary>
    Bag,
    /// <summary>盒子</summary>
    Box,
    /// <summary>商店</summary>
    Shop
}

public enum InventoryLocation
{
    Player,
    Box
}
