using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MFarm.Inventory
{
    public class InventoryManager : Singleton<InventoryManager>
    {
        [Header("物品数据")]
        public ItemDataList_SO itemDataList_SO;
        [Header("玩家背包数据")]
        public InventoryBag_SO playerBag;

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
            //背包是否有空位
            //是否已经有了这个物品
            InventoryItem newItem = new InventoryItem();
            newItem.itemID = item.itemID;
            newItem.itemAmount = 1;

            playerBag.itemList[0] = newItem;

            Debug.Log(GetItemDetails(item.itemID).ItemId + "Name:" + GetItemDetails(item.itemID).ItemName);
            if (toDestory)
            {
                Destroy(item.gameObject);
            }
        }
    }
}
