using UnityEngine; 
 
public class SourceController : MonoBehaviour  
{ 
    public AudioClip clipMedieval; 
    public AudioClip clipArcade; 
 
    private AudioSource audioSourceMedieval; 
    private AudioSource audioSourceArcade; 
 
    void Awake() 
    { 
        audioSourceMedieval = CreateAudioSource(clipMedieval, true); 
        audioSourceArcade = CreateAudioSource(clipArcade, false); 
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
    
    private AudioSource CreateAudioSource(AudioClip audioClip, bool startPlayingImmediately) 
    { 
        GameObject audioSourceGO = new GameObject(); 
        audioSourceGO.transform.parent = transform; 
        audioSourceGO.transform.position = transform.position; 
        AudioSource newAudioSource = audioSourceGO.AddComponent<AudioSource>(); 
        newAudioSource.clip = audioClip;
        if (startPlayingImmediately) {
            newAudioSource.Play();
        }
    
        return newAudioSource; 
    } 
} 
