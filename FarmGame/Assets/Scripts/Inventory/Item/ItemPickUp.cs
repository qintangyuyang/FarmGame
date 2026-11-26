using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MFarm.Inventory
{
    public class ItemPickUp : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collision)
        {
            Item item = collision.GetComponent<Item>();
            //看碰到的物体是不是item
            if (item != null)
            {
                if (item.itemDetails.canPickedup)
                {
                    //拾取物品添加到背包
                    InventoryManager.Instance.AddItem(item, true);
                }
            }
        }
    }
}
