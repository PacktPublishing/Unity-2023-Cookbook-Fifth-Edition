using UnityEngine; 
 
public class SourceController : MonoBehaviour  
{ 
    public AudioSource audioSourceMedieval; 
    public AudioSource audioSourceArcade; 
 
    void Update() 
    { 
        if (Input.GetKey(KeyCode.RightArrow)) { 
            PlayUnpause(audioSourceMedieval);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            audioSourceMedieval.Pause();
        }
             
        if (Input.GetKey(KeyCode.UpArrow)) {
            PlayUnpause(audioSourceArcade);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            audioSourceArcade.Pause();
        }
    }

    private void PlayUnpause(AudioSource audioSource)
    {
        if (audioSource.time > 0) {
            audioSource.UnPause();
        } else {
            audioSource.Play();
        }
    }
} 
