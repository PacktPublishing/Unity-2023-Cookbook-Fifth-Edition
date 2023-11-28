using UnityEngine; 
using UnityEngine.UI; 
using TMPro;

public class DisplayChangedTextContent : MonoBehaviour { 
   public InputField inputField; 
   private TextMeshProUGUI textDisplay; 

   void Awake() { 
         textDisplay = GetComponent<TextMeshProUGUI>(); 
   } 

   public void DisplayNewValue () { 
         textDisplay.text = "last entry = '" + inputField.text + "'"; 
   } 
} 

