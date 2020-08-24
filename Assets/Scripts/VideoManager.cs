using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    public VideoClip[] videos;

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



    public void livingVideo()
    {
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videos[0];
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }

    public void cuboVideo()
    {
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videos[1];
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }

    public void cantinaVideo()
    {
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videos[2];
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    public void mezzanineVideo()
    {
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videos[3];
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }

    private void VideoPlayer_prepareCompleted(VideoPlayer source)
    {
        Play();
    }
}