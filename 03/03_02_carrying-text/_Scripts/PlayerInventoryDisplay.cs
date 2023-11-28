using UnityEngine;
using TMPro;

[RequireComponent(typeof(PlayerInventory))]
public class PlayerInventoryDisplay : MonoBehaviour 
{
	// reference to a TMP Text object
	// public - so we have to assign via the Inspector
	public TextMeshProUGUI starText;


	//------------------------------
	// update the text message on screen
	// to indicate if we are carrying the star or not
	public void OnChangeCarryingStar(bool carryingStar)
	{
		// default message - we're not carrying a star
		string starMessage = "no star :-(";

		// if we ARE carrying a star then set message to say this
		if(carryingStar)
			starMessage = "Carrying star :-)";

		// update UI text on screen with whatever is in our messsage string
		starText.text = starMessage;
	}
}