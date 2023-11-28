using UnityEngine;
using TMPro;

public class PlayerInventoryCombined : MonoBehaviour { 
      public TextMeshProUGUI starText; 
      private bool carryingStar = false; 
      
      private void Start() 
      { 
            UpdateStarText(); 
      } 
      
      void OnTriggerEnter2D(Collider2D hit) 
      {
            if (hit.CompareTag("Star"))
            { 
                  carryingStar = true; 
                  UpdateStarText(); 
                  Destroy(hit.gameObject); 
            }
      } 
      
      private void UpdateStarText() 
      { 
            string starMessage = "no star :-(";
            if (carryingStar)
            {
                  starMessage = "Carrying star :-)";
            }

            starText.text = starMessage; 
      } 
} 
