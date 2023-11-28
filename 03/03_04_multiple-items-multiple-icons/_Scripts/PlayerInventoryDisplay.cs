using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerInventory))]
public class PlayerInventoryDisplay : MonoBehaviour
{
    // reference to an array of UI images
    // public - so set in Inspector
    public Image[] starPlaceholders;
    
    // reference to image of yellow Star
    public Sprite iconStarYellow;
    
    // reference to image of gray Star
    public Sprite iconStarGrey;

    public void OnChangeStarTotal(int starTotal)
    {
        // loop for the number of items in the Image array
        for (int i = 0; i < starPlaceholders.Length; ++i)
        {
            // if the current count is less that number of stars carried:
            if (i < starTotal)
            {
                // THEN display Yellow star
                starPlaceholders[i].sprite = iconStarYellow;
            }
            else
            {
                // ELSE display Gray star
                starPlaceholders[i].sprite = iconStarGrey;
            }
        }
    }
}
