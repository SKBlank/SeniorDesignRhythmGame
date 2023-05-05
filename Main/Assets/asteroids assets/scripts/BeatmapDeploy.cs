using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

public class BeatmapDeploy : MonoBehaviour
{
    

    public VideoPlayer player;

    public void chooseMap() {
        if(PlayerPrefs.GetInt("difficulty") == 0 && PlayerPrefs.GetInt("difficulty") == 0) {
            player.clip = Resources.Load<VideoClip>("Main/Assets/asteroids assets/video/pixels_aster_ez_-_short.mp4");
        }
        else if (PlayerPrefs.GetInt("difficulty") == 0 && PlayerPrefs.GetInt("extended") == 1) {
            player.clip = Resources.Load<VideoClip>("Main/Assets/asteroids assets/video/pixels_aster_ez.mp4");
        }
        else if (PlayerPrefs.GetInt("difficulty") == 1 && PlayerPrefs.GetInt("extended") == 0) {
            player.clip = Resources.Load<VideoClip>("Main/Assets/asteroids assets/video/pixels_aster_hard_-_short.mp4");
        }
        else {
            player.clip = Resources.Load<VideoClip>("Main/Assets/asteroids assets/video/pixels_aster_hard_1.mp4");
        }
         
    }
}
