using UnityEngine; 
 
public class SourceControllerUsingExtensionMethod : MonoBehaviour  
{ 
    public AudioClip clipMedieval; 
    public AudioClip clipArcade; 
 
    private AudioSource audioSourceMedieval; 
    private AudioSource audioSourceArcade; 
 
    void Awake() 
    { 
        audioSourceMedieval = this.CreateAudioSource(clipMedieval, true); 
        audioSourceArcade = this.CreateAudioSource(clipArcade, false); 
    } 
 
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
