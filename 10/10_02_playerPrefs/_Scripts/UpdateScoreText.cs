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
		int scoreCorrect = PlayerPrefs.GetInt("scoreCorrect");
		int scoreIncorrect = PlayerPrefs.GetInt("scoreIncorrect");
 
		int totalAttempts = scoreCorrect + scoreIncorrect;
		string scoreMessage = "Score = ";
		scoreMessage += scoreCorrect + " / " + totalAttempts;
 
		_scoreText.text = scoreMessage;
	}
}