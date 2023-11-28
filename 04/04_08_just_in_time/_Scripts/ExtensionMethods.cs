using UnityEngine; 
 
public static class ExtensionMethods 
{ 
    public static AudioSource CreateAudioSource(this MonoBehaviour parent, AudioClip audioClip, bool startPlayingImmediately) 
    { 
         GameObject audioSourceGO = new GameObject("music-player"); 
         audioSourceGO.transform.parent = parent.transform; 
         audioSourceGO.transform.position = parent.transform.position; 
         AudioSource newAudioSource = audioSourceGO.AddComponent<AudioSource>() as AudioSource; 
         newAudioSource.clip = audioClip;

         if (startPlayingImmediately) {
             newAudioSource.Play();
         }
               
         return newAudioSource; 
    } 
} 
