using UnityEngine; 

public class PlayerController : MonoBehaviour { 
   private InventoryManager inventoryManager; 

   // cache reference to InventoryManager component
   void Awake() { 
         inventoryManager = GetComponent<InventoryManager>(); 
   } 

   // add Pickup component of hit object to inventory manager
   // (and destroy hit GameObject)
   void OnTriggerEnter2D(Collider2D hit) { 
         if(hit.CompareTag("Pickup")){ 
            PickUp item = hit.GetComponent<PickUp> ();
            inventoryManager.Add(item); 
            Destroy(hit.gameObject); 
         } 
   } 
} 
