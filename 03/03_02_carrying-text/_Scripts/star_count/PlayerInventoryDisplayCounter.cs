using UnityEngine;
using TMPro;

[RequireComponent(typeof(PlayerInventoryCounter))]
public class PlayerInventoryDisplayCounter : MonoBehaviour 
{
	// reference to a TMP Text object
	// public - so we have to assign via the Inspector
	public TextMeshProUGUI starText;


	//------------------------------
	// update the text message on screen
	// to indicate if we are carrying the star or not
	public void OnChangeCarryingStar(int numStars)
	{
		// message stating star count
		string starMessage = "total stars = " + numStars;

		// update UI text on screen with whatever is in our message string
		starText.text = starMessage;
	}
}