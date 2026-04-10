using UnityEngine;
using System.Collections.Generic;

public class InventoryItem
{
    public string itemID;
    public int count;
}

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> itemList;

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

    }
}
