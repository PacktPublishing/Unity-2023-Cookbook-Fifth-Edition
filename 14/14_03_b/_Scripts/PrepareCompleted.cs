using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Collections; 
 
public class PrepareCompleted: MonoBehaviour {
    public RawImage image;
    public VideoClip videoClip;
 
    private VideoPlayer videoPlayer;
    private AudioSource audioSource;
 
    private IEnumerator Start() {
        Debug.Log("start");
        SetupVideoAudioPlayers();
        videoPlayer.Prepare();
 
        while (!videoPlayer.isPrepared)
           yield return null;
 
        videoPlayer.Play();
        Debug.Log("A-Playing");
        yield return null;
    } 

    private void SetupVideoAudioPlayers() {
        Debug.Log("2");
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();
 
        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;
 
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videoClip;
 
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);
    }
 
 
} 

