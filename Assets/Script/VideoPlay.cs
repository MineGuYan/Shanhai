using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{
    private VideoPlayer player;
    public GameObject screen;
    public List<float> videoTime = new List<float>();
    public List<VideoClip> clip = new List<VideoClip>();
    private void Awake()
    {
        player = GetComponent<VideoPlayer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.clockTime > videoTime[StoryClick.instance.Index]) Stop();
    }

    public void Play()
    {
        screen.SetActive(true);
        player.clip = clip[StoryClick.instance.Index];
        player.Play();
    }
    public void Stop()
    {
        player.Stop();
        screen.SetActive(false);
    }
}
