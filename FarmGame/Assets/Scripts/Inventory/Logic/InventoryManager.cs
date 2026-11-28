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

        void Start()
        {
            EventHandler.CallUpdataInventoryUI(InventoryLocation.Player, playerBag.itemList);
        }

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
            //是否已经有了这个物品
            var index = GetItemIndexInBag(item.itemID);

            AddItemAtIndex(item.itemID, index, 1);

            Debug.Log(GetItemDetails(item.itemID).ItemId + "Name:" + GetItemDetails(item.itemID).ItemName);
            if (toDestory)
            {
                Destroy(item.gameObject);
            }

            //更新UI
            EventHandler.CallUpdataInventoryUI(InventoryLocation.Player, playerBag.itemList);
        }

        /// <summary>
        /// 检查背包是否有空位
        /// </summary>
        /// <returns></returns>
        private bool CheckBagCapacity()
        {
            for (int i = 0; i < playerBag.itemList.Count; i++)
            {
                if (playerBag.itemList[i].itemID == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 通过物品id找到背包已有物品位置
        /// </summary>
        /// <param name="id">物品id</param>
        /// <returns>-1则没有这个物品否则返回序号</returns>
        private int GetItemIndexInBag(int id)
        {
            for (int i = 0; i < playerBag.itemList.Count; i++)
            {
                if (playerBag.itemList[i].itemID == id)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 在指定背包序号位置添加物品
        /// </summary>
        /// <param name="id">物品ID</param>
        /// <param name="index">序号</param>
        /// <param name="amount">数量</param>
        private void AddItemAtIndex(int id, int index, int amount)
        {
            //背包没有这个物品 同时背包有空位
            if (index == -1 && CheckBagCapacity())
            {
                //创建新物品
                var item = new InventoryItem { itemID = id, itemAmount = amount };
                for (int i = 0; i < playerBag.itemList.Count; i++)
                {
                    //找到空位直接赋值过去
                    if (playerBag.itemList[i].itemID == 0)
                    {
                        playerBag.itemList[i] = item;
                        break;
                    }
                }
            }
            //背包有这个物品
            else
            {
                int currentAmount = playerBag.itemList[index].itemAmount + amount;
                var item = new InventoryItem { itemID = id, itemAmount = currentAmount };
                playerBag.itemList[index] = item;
            }
        }
    }
}
