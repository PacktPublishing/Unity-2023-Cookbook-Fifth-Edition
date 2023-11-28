using UnityEngine;

[RequireComponent(typeof(PlayerInventoryKeys))] 
public class PlayerInventoryDisplayKeysStars : MonoBehaviour
{
    public PickupUI[] slotsStars = new PickupUI[1]; 
    public PickupUI[] slotsKeys = new PickupUI[1]; 
    
    public void OnChangeStarTotal(int starTotal)
    {
        UpdateSlotDisplays(starTotal, slotsStars);
    }
    
    public void OnChangeKeyTotal(int keyTotal) { 
        UpdateSlotDisplays(keyTotal, slotsKeys);
    }

    private void UpdateSlotDisplays(int pickupTotal, PickupUI[] iconSlots)
    {
        int numInventorySlots = iconSlots.Length; 
        for(int i = 0; i < numInventorySlots; i++){ 
            PickupUI slot = iconSlots[i]; 
            if(i < pickupTotal) 
                slot.DisplayColorIcon(); 
            else 
                slot.DisplayGreyIcon(); 
        }
    }
}