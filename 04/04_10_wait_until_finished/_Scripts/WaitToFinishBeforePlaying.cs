using UnityEngine;
using TMPro;

public class WaitToFinishBeforePlaying : MonoBehaviour 
{
	public AudioSource audioSource;
	public TextMeshProUGUI buttonText;

    // each frame ensure button text tells user whether sound is playing, or ready to play again
	void Update()
    {
		string statusMessage = "(Re)Play sound";
		if (audioSource.isPlaying) {
			statusMessage = "(sound playing)";
		}

		buttonText.text = statusMessage;
	}

    // BUTTON click action
    // if not still playing, then send audio source a Play() message
	public void ACTION_PlaySoundIfNotPlaying()
    {
		if( !audioSource.isPlaying )
			audioSource.Play();
	}
}