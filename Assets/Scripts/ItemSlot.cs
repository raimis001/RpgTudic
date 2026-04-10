using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour
{
    public Image icon;
    public TMP_Text caption;
    public TMP_Text count;

    public void SetItem(Sprite sprite, string caption, int count)
    {
        icon.sprite = sprite;
        this.caption.text = caption;
        this.count.text = count.ToString();
    }
}
