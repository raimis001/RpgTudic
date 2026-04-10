using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class ItemData
{
    public string itemID;
    public Sprite icon;
    public string description;
}

public class InventoryItem
{
    public string itemID;
    public int count;
}

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> itemList = new List<InventoryItem>();

    public void AddItem(string itemID, int count)
    {
        foreach (InventoryItem item in itemList)
        {
            if (item.itemID == itemID)
            {
                item.count += count;
                return;
            }
        }

        InventoryItem newItem = new InventoryItem();
        newItem.itemID = itemID;
        newItem.count = count;
    }

    public void RemoveItem(string itemID, int count)
    {
        foreach (InventoryItem item in itemList)
        {
            if (item.itemID == itemID)
            {
                item.count -= count;
                return;
            }
        }
    }
}
