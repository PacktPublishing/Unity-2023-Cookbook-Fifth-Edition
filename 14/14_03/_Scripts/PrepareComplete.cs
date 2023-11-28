using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
 
public class PrepareCompleted: MonoBehaviour {
    public RawImage image;
    public VideoClip videoClip;
 
    private VideoPlayer videoPlayer;
    private AudioSource audioSource;
 
    void Start() {
        SetupVideoAudioPlayers();
        videoPlayer.prepareCompleted += PlayVideoWhenPrepared;
        videoPlayer.Prepare();
        Debug.Log("A - PREPARING");
    }
 
    private void SetupVideoAudioPlayers() {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();
 
        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;
 
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videoClip;
 
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);
    }
 
    private void PlayVideoWhenPrepared(VideoPlayer theVideoPlayer) {
        Debug.Log("B - IS PREPARED");
        image.texture = theVideoPlayer.texture;
        Debug.Log("C - PLAYING");
        theVideoPlayer.Play();
    }
} 

