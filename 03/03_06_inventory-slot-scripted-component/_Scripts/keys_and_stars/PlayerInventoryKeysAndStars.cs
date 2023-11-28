using UnityEngine;

public class PlayerInventoryKeysAndStars : MonoBehaviour
{
	private int starTotal = 0; 
	private int keyTotal = 0; 

	// a cached reference to an instance of class PlayerInventoryDisplay
	private PlayerInventoryDisplayKeysStars playerInventoryDisplay;

	//------------------------
	// cache a reference to the PlayerInventoryDisplay object
	// that is in the parent GameObject
	void Awake()
	{
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplayKeys>();
	}

	//------------------------
	// Ensure UI display matches this initial state
	// of whether we are carrying a star or not
	void Start()
	{
		playerInventoryDisplay.OnChangeStarTotal(starTotal); 
		playerInventoryDisplay.OnChangeKeyTotal(keyTotal); 

	}

	
	void OnTriggerEnter2D(Collider2D hit) { 
		if(hit.CompareTag("Star")){ 
			AddStar(); 
			Destroy(hit.gameObject); 
		} 
 
		if(hit.CompareTag("Key")){ 
			AddKey(); 
			Destroy(hit.gameObject); 
		} 
	} 

	private void AddStar() { 
		starTotal++; 
		playerInventoryDisplay.OnChangeStarTotal(starTotal); 
	} 

	private void AddKey() { 
		keyTotal++; 
		playerInventoryDisplay.OnChangeKeyTotal(keyTotal); 
	} 

}