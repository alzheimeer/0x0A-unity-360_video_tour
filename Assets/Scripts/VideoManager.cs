using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    GameObject dd;


    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    public void Play()
    {
        videoPlayer.Play();
    }

    public void Pause()
    {
        videoPlayer.Pause();
    }
    public void Stop()
    {
        videoPlayer.Stop();
    }

    void Awake()
    {

        //Find the fader object
        dd = GameObject.Find("Video Player");

    }
    public void cuboVideo()
    {

        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "Assets/videos/Cube.mp4";
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    public void livingVideo()
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "Assets/videos/LivingRoom.mp4";
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    public void mezzanineVideo()
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "Assets/videos/Mezzanine.mp4";
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    public void cantinaVideo()
    {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = "Assets/videos/Cantina.mp4";
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    private void VideoPlayer_prepareCompleted(VideoPlayer source)
    {
        Play();
    }
}