using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public string itemID;
    public int count = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory inventory = FindAnyObjectByType<Inventory>();
            inventory.AddItem(itemID, count);
            Destroy(gameObject);
        }
    }
}
