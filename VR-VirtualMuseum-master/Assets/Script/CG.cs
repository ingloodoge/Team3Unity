using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CG : MonoBehaviour
{
    private VideoPlayer VideoPlayer;
    public GameObject CGimg;
    public UITips UITips;
    public UIPick UIPick;
    private Information Information;

    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer = GetComponent<VideoPlayer>();
        CGimg.SetActive(false);
       
    }

    // Update is called once per frame
    

    public void playVideo(VideoClip videoClip)
    {
        VideoPlayer.clip = videoClip;
        CGimg.SetActive(true);
        VideoPlayer.Play();
    }
    public void stopVideo()
    {
        if (VideoPlayer.clip != null)
        {
            VideoPlayer.Stop();
            CGimg.SetActive(false);
            UIPick.show(Information.Pickuptips);
        }
        
    }
}
