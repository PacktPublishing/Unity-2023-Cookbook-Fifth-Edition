using UnityEngine;
using System.Collections.Generic; 
using TMPro;

[RequireComponent(typeof(PlayerInventory))] 
public class PlayerInventoryDisplay : MonoBehaviour 
{ 
    public TextMeshProUGUI inventoryText; 

    public void OnChangeInventory(List<PickUp> inventory) 
    {
        // sort alphabetically
        inventory.Sort( 
            delegate(PickUp p1, PickUp p2){ 
                return p1.description.CompareTo(p2.description); 
            } 
        ); 

        // (1) clear existing display 
        inventoryText.text = ""; 

        // (2) build up new set of items  
        string newInventoryText = "carrying: "; 
        int numItems = inventory.Count; 
        for(int i = 0; i < numItems; i++){ 
            string description = inventory[i].description; 
            newInventoryText += " [" + description+ "]"; 
        } 

        // if no items in List then set string to empty message 
        if(numItems < 1) 
            newInventoryText = "(empty inventory)"; 

        // (3) update screen display 
        inventoryText.text = newInventoryText; 
    } 
} 
