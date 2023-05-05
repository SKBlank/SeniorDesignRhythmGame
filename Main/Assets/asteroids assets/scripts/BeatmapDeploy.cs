using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

public class BeatmapDeploy : MonoBehaviour
{
    

    public VideoPlayer player;

    public int sceneNum;

    public VideoClip map1;
    public VideoClip map2;
    public VideoClip map3;
    public VideoClip map4;
    

    void OnEnable() {
        print("test");
        Debug.Log(PlayerPrefs.GetInt("difficulty"));
            if(PlayerPrefs.GetInt("difficulty") == 0 && PlayerPrefs.GetInt("difficulty") == 0) {
                player.clip = map1;
            }
            else if (PlayerPrefs.GetInt("difficulty") == 0 && PlayerPrefs.GetInt("extended") == 1) {
                player.clip = map2;
            }
            else if (PlayerPrefs.GetInt("difficulty") == 1 && PlayerPrefs.GetInt("extended") == 0) {
                player.clip = map3;
            }
            else {
                player.clip = map4;
            }
            Debug.Log("test1234");
            player.Play();

    }
}
