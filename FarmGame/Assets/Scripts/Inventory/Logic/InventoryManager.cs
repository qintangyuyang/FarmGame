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

        /// <summary>
        /// 添加物品到Player的背包
        /// </summary>
        /// <param name="item"></param>
        /// <param name="toDestory">是否要销毁物品</param>
        public void AddItem(Item item, bool toDestory)
        {
            Debug.Log(GetItemDetails(item.itemID).ItemId + "Name:" + GetItemDetails(item.itemID).ItemName);
            if (toDestory)
            {
                Destroy(item.gameObject);
            }
        }
    }
}
