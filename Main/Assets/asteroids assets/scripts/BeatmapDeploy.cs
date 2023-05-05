using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

public class BeatmapDeploy : MonoBehaviour
{
    

    public VideoPlayer player;

    public int sceneNum;

    public void start() {
        if(sceneNum == 1) {
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

            player.Play();
        }
        else {
            if(PlayerPrefs.GetInt("difficulty") == 0 && PlayerPrefs.GetInt("difficulty") == 0) {
                player.clip = Resources.Load<VideoClip>("Main/Assets/New arrow assets/arrow maps/pixels_new_arrows_easy_-_short.mp4");
            }
            else if (PlayerPrefs.GetInt("difficulty") == 0 && PlayerPrefs.GetInt("extended") == 1) {
                player.clip = Resources.Load<VideoClip>("Main/Assets/New arrow assets/arrow maps/pixels new arrows easy 5s offset.mp4");
            }
            else if (PlayerPrefs.GetInt("difficulty") == 1 && PlayerPrefs.GetInt("extended") == 0) {
                player.clip = Resources.Load<VideoClip>("Main/Assets/New arrow assets/arrow maps/pixels_new_arrows_hard_-_short_.mp4");
            }
            else {
                player.clip = Resources.Load<VideoClip>("Assets/New arrow assets/arrow maps/pixels new arrows hard.mp4");
            }

            player.Play();
        }
    }
}
