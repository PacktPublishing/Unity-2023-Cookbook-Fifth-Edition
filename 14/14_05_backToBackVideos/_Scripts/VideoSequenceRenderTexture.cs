using UnityEngine;
using UnityEngine.Video;

public class VideoSequenceRenderTexture : MonoBehaviour {
     public RenderTexture renderTexture;
     public VideoClip[] videoClips;

     private VideoPlayer[] videoPlayers;
     private int currentVideoIndex;

     void Start() {
         SetupObjectArrays();
         currentVideoIndex = 0;
         videoPlayers[currentVideoIndex].prepareCompleted += PlayNextVideo;
         videoPlayers[currentVideoIndex].Prepare();
         Debug.Log("A - PREPARING video: " + currentVideoIndex);
     }

     private void SetupObjectArrays() {
         videoPlayers = new VideoPlayer[videoClips.Length];
         for (int i = 0; i < videoClips.Length; i++)
             SetupVideoAudioPlayers(i);
     }

     private void PlayNextVideo(VideoPlayer theVideoPlayer) {
         VideoPlayer currentVideoPlayer = videoPlayers[currentVideoIndex];

         Debug.Log("B - PLAYING Index: " + currentVideoIndex);
         currentVideoPlayer.Play();

         currentVideoIndex++;
         bool someVideosLeft = currentVideoIndex < videoPlayers.Length;

         if (someVideosLeft) {
             VideoPlayer nextVideoPlayer = videoPlayers[currentVideoIndex];
             nextVideoPlayer.Prepare();
             Debug.Log("A - PREPARING video: " + currentVideoIndex);
             currentVideoPlayer.loopPointReached += PlayNextVideo;
         } else {
             Debug.Log("(no videos left)");
         }
     }

     private void SetupVideoAudioPlayers(int i) {
         string newGameObjectName = "videoPlayer_" + i;
         GameObject containerGo = new GameObject(newGameObjectName);
         containerGo.transform.SetParent(transform);
         containerGo.transform.SetParent(transform);

         VideoPlayer videoPlayer = containerGo.AddComponent<VideoPlayer>();
         AudioSource audioSource = containerGo.AddComponent<AudioSource>();

         videoPlayers[i] = videoPlayer;

         videoPlayer.playOnAwake = false;
         audioSource.playOnAwake = false;

         videoPlayer.source = VideoSource.VideoClip;
         videoPlayer.clip = videoClips[i];

         videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
         videoPlayer.SetTargetAudioSource(0, audioSource);

         videoPlayer.renderMode = VideoRenderMode.RenderTexture;
         videoPlayer.targetTexture = renderTexture;
     }
 } 