using UnityEngine;

public class IncrementCorrectScore : MonoBehaviour
{
	void Start ()
	{
		// add 1 to score
		int newScoreCorrect = 1 + PlayerPrefs.GetInt("scoreCorrect");
		PlayerPrefs.SetInt("scoreCorrect", newScoreCorrect);

	}
}