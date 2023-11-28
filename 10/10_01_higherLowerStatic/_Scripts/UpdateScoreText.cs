using UnityEngine;
using TMPro;

public class UpdateScoreText : MonoBehaviour
{
	private TextMeshProUGUI _scoreText;

	/*-------------------------------------------
	 * cache a reference to the text component in same GameObject
	 */
	private void Awake()
	{
		_scoreText = GetComponent<TextMeshProUGUI>();
	}


	/*-------------------------------------------
	 * load scores from Player static variables
	 * and display on screen in sibling UI Text component
	 */
	void Start()
	{ 
		int totalAttempts = PlayerData.scoreCorrect + PlayerData.scoreIncorrect;
		
		// version 1 - always show score totals (even if 0/0)
		// string scoreMessage = "Score = ";
		// scoreMessage += PlayerData.scoreCorrect + " / " + totalAttempts;
		
		// version 2 - default is empty string
		string scoreMessage = "";
		if (totalAttempts > 0)
		{
		    scoreMessage = "Score = ";
		    scoreMessage += PlayerData.scoreCorrect + " / " + totalAttempts;
		}

		_scoreText.text = scoreMessage;
	}
}