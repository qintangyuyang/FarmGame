using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    /// <summary>物品id</summary>
    public int ItemId;

    /// <summary>物品名字</summary>
    public string name;

    /// <summary>物品类型</summary>
    public ItemType itemType;

    /// <summary>物品icon</summary>
    public Sprite itemIcon;

    /// <summary>在世界地图上产生时显示的图片</summary>
    public Sprite itemOnWorldSprite;

    /// <summary>item详情</summary>
    public string itemDescription;

    /// <summary>使用范围</summary>
    public int itemUseRadius;

    /// <summary>是否能被拾取</summary>
    public bool canPickedup;

    /// <summary>是否能被扔下</summary>
    public bool canDropped;

    /// <summary>是否能被携带</summary>
    public bool canCarried;

    /// <summary>物品价值</summary>
    public int itemPrice;

    /// <summary>售卖时折扣的百分比</summary>
    [Range(0, 1)]
    public float seelPercentage;
}
