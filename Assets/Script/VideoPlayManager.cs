using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayManager : MonoBehaviour
{
    private VideoPlayer player;
    public GameObject screen;
    public float videoTime;
    public TaskManager.TaskProgress progress;
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        VideoPlay();
    }

    void Update()
    {
        if(player.clockTime > videoTime) VideoFinish();
    }

    public void VideoPlay()
    {
        if(progress==TaskManager.instance.taskProgress)
        {
            BGMManager.player.Pause();
            Time.timeScale = 0.0f;
            player.Play();
        }
        else screen.SetActive(false);
    }

    public void VideoFinish()
    {
        player.Stop();
        Time.timeScale = 1.0f;
        BGMManager.player.Play();
        TaskManager.instance.TaskFinish();
        screen.SetActive(false);
    }
}
