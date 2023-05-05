using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

public class IfOver : MonoBehaviour
{
    public GameObject VP;
    public MenuManager manage;
    private int timePassed = 0;

    void Update()
    {
        timePassed++;

        if(timePassed == 1000)
        {
            print("Time passed");
            if (VP.GetComponent<VideoPlayer>().isPlaying == false)
            {
                print("Video is not playing");
                manage.LoadLevelButton("New arrow");
            }
            else
            {
                print("Video is playing");
            }
        }
    }

}
