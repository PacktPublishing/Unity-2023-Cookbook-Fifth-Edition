using UnityEngine; 
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private List<PickUp> inventory = new List<PickUp>();

    void Awake()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>
            ();
    }

    void Start()
    {
        playerInventoryDisplay.OnChangeInventory(inventory);
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Pickup"))
        {
            PickUp item = hit.GetComponent<PickUp>();
            inventory.Add(item);
            playerInventoryDisplay.OnChangeInventory(inventory);
            Destroy(hit.gameObject);
        }
    }
}