using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MFarm.Inventory
{
    public class InventoryManager : Singleton<InventoryManager>
    {
        public ItemDataList_SO itemDataList_SO;

        /// <summary>根据id快速找到物品详情</summary>
        public ItemDetails GetItemDetails(int id)
        {
            return itemDataList_SO.itemDetailsList.Find(i => i.ItemId == id);
        }
    }
}
