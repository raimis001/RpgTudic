using UnityEngine;

public class Hause : MonoBehaviour
{
    public GameObject facade;
    public GameObject interior;

    public bool locked = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (locked)
            return;
        
        if (!collision.CompareTag("Player"))
            return;

        if (facade.activeSelf)
        {
            facade.SetActive(false);
            interior.SetActive(true);
        }
        else
        {
            facade.SetActive(true);
            interior.SetActive(false);
        }
    }
}
