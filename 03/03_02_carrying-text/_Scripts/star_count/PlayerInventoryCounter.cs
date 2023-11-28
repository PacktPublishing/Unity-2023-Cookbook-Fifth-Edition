using UnityEngine;

public class PlayerInventoryCounter : MonoBehaviour
{
	// a cached reference to an instance of class PlayerInventoryDisplay
	private PlayerInventoryDisplayCounter playerInventoryDisplay;

	// total stars being carried
	private int totalStars = 0;

	//------------------------
	// cache a reference to the PlayerInventoryDisplay object
	// that is in the parent GameObject
	void Awake()
	{
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplayCounter>();
	}

	//------------------------
	// Ensure UI display matches this initial state
	// of whether we are carrying a star or not
	void Start()
	{
		playerInventoryDisplay.OnChangeCarryingStar(totalStars);
	}

    //--------------------------
	// when we hit a star, update carrying flag
	// and update the display
	// (and remove the star GameObject)
	void OnTriggerEnter2D(Collider2D hit)
	{
		// IF we hit something tagged 'Star'
		if (hit.CompareTag("Star"))
		{
			// add 1 to star count
			totalStars++;

			// update the UI display of our star carrying status
			playerInventoryDisplay.OnChangeCarryingStar(totalStars);

			// destroy the star object that we collided with
			Destroy(hit.gameObject);
		}
	}
}
