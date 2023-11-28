using UnityEngine;

public class IncrementIncorrectScore : MonoBehaviour
{
	void Start ()
	{
		// subtract 1 from score
		int newScoreIncorrect = 1 + PlayerPrefs.GetInt("scoreIncorrect");
		PlayerPrefs.SetInt("scoreIncorrect", newScoreIncorrect);
	}
}
