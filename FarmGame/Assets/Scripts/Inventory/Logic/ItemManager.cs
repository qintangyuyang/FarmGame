using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MFarm.Inventory
{
    public class ItemManager : MonoBehaviour
    {
        public Item itemPrefab;
        private Transform itemParent;

        void OnEnable()
        {
            EventHandler.InstantiateItemInScene += OnInstantiateInScene;
        }
        void OnDisable()
        {
            EventHandler.InstantiateItemInScene -= OnInstantiateInScene;
        }

        void Start()
        {
            itemParent = GameObject.FindWithTag("ItemParent").transform;
        }

        private void OnInstantiateInScene(int ID, Vector3 pos)
        {
            var item = Instantiate(itemPrefab, pos, Quaternion.identity, itemParent);
            item.itemID = ID;
        }
    }
}
