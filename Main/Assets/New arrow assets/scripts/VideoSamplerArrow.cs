using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSamplerArrow : MonoBehaviour
{

    //For this to work, we need a VideoPlayer with an assigned video in the scene.
    //Its Render Mode must be set to Render Texture.
    //Pass this video player to videoPlayer.
    //Pass the Render Texture to renderTexture.

    //For my example, I have an object in the scene with a script called Instantiater.
    //It has a function called spawnObject() which instantiates a new object.
    //On launch, this script searches for an object called Instantiater and gets its script.
    //This could be done in another way, of course.
    //The important thing is that triggerEvent() calls spawnObject().

    public GameObject videoPlayer;
    // public Instantiater instantiaterScript;
  
    private UnityEngine.Video.VideoPlayer videoPlayerScript;

    public RenderTexture renderTexture;
    public float brightnessThreshold = 0.1f;

    public GameObject[] gridObjects;

    public Color LastSampled00;
    public Color LastSampled01;
    public Color LastSampled02;
    public Color LastSampled03;
    public Color LastSampled04;

    public Color LastSampled10;
    public Color LastSampled11;
    public Color LastSampled12;
    public Color LastSampled13;
    public Color LastSampled14;

    public Color LastSampled20;
    public Color LastSampled21;
    public Color LastSampled22; //planet
    public Color LastSampled55; //planet
    public Color LastSampled23;
    public Color LastSampled24;

    public Color LastSampled30;
    public Color LastSampled31;
    public Color LastSampled32;
    public Color LastSampled33;
    public Color LastSampled34;

    public Color LastSampled40;
    public Color LastSampled41;
    public Color LastSampled42;
    public Color LastSampled43;
    public Color LastSampled44;

    private bool seenBlack00;
    private bool seenBlack01;
    private bool seenBlack02;
    private bool seenBlack03;
    private bool seenBlack04;

    private bool seenBlack10;
    private bool seenBlack11;
    private bool seenBlack12;
    private bool seenBlack13;
    private bool seenBlack14;

    private bool seenBlack20;
    private bool seenBlack21;
    private bool seenBlack22;
    private bool seenBlack55;
    private bool seenBlack23;
    private bool seenBlack24;

    private bool seenBlack30;
    private bool seenBlack31;
    private bool seenBlack32;
    private bool seenBlack33;
    private bool seenBlack34;

    private bool seenBlack40;
    private bool seenBlack41;
    private bool seenBlack42;
    private bool seenBlack43;
    private bool seenBlack44;


    


    // We need to store the Instantiater script so we can call its spawnObject() function
   
    // Start is called before the first frame update
    void Start()
    {
        videoPlayerScript = videoPlayer.GetComponent<VideoPlayer>();

        seenBlack00 = false;
        seenBlack01 = false;
        seenBlack02 = false;
        seenBlack03 = false;
        seenBlack04 = false;

        seenBlack10 = false;
        seenBlack11 = false;
        seenBlack12 = false;
        seenBlack13 = false;
        seenBlack14 = false;

        seenBlack20 = false;
        seenBlack21 = false;
        seenBlack22 = false;
        seenBlack55 = false;
        seenBlack23 = false;
        seenBlack24 = false;

        seenBlack30 = false;
        seenBlack31 = false;
        seenBlack32 = false;
        seenBlack33 = false;
        seenBlack34 = false;
        
        seenBlack40 = false;
        seenBlack41 = false;
        seenBlack42 = false;
        seenBlack43 = false;
        seenBlack44 = false;
    }

    // Update is called once per frame
    void Update()
    {
        long currentFrame = videoPlayerScript.frame;
        // Debug.Log("Sampling:" + currentFrame);
        sampleFrame(currentFrame);
    }

    void sampleFrame(long frame)
    {
        
        //Prepare the video player to sample the frame
        RenderTexture.active = renderTexture;
        Texture2D tex = new Texture2D(renderTexture.width, renderTexture.height);
        //Generate a sampleable rect from the render texture
        tex.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        tex.Apply();

        Color C00 = tex.GetPixel(13, 113);
        Color C01 = tex.GetPixel(38, 113);
        Color C02 = tex.GetPixel(63, 113);
        Color C03 = tex.GetPixel(88, 113);
        Color C04 = tex.GetPixel(113, 113);

        Color C10 = tex.GetPixel(13, 88);
        Color C11 = tex.GetPixel(38, 88);
        Color C12 = tex.GetPixel(63, 88);
        Color C13 = tex.GetPixel(88, 88);
        Color C14 = tex.GetPixel(113, 88);

        Color C20 = tex.GetPixel(13, 63);
        Color C21 = tex.GetPixel(38, 63);
        //planets////////////////////////
        Color C22 = tex.GetPixel(56, 63);
        Color C55 = tex.GetPixel(70, 63);
        /////////////////////////////////
        Color C23 = tex.GetPixel(88, 63);
        Color C24 = tex.GetPixel(113, 63);

        Color C30 = tex.GetPixel(13, 38);
        Color C31 = tex.GetPixel(38, 38);
        Color C32 = tex.GetPixel(63, 38);
        Color C33 = tex.GetPixel(88, 38);
        Color C34 = tex.GetPixel(113, 38);

        Color C40 = tex.GetPixel(13, 13);
        Color C41 = tex.GetPixel(38, 13);
        Color C42 = tex.GetPixel(63, 13);
        Color C43 = tex.GetPixel(88, 13);
        Color C44 = tex.GetPixel(113, 13);


        
        if (seenBlack00 == false)
        {
            if (Color.black == C00)
            {
                seenBlack00 = true;
            }
        }
        else
        {
            if (C00.r > brightnessThreshold || C00.g > brightnessThreshold || C00.b > brightnessThreshold)
            {
                gridObjects[0].SetActive(true);
                gridObjects[0].SetActive(false);
                seenBlack00 = false;
            }
        }
        if (seenBlack01 == false)
        {
            if (Color.black == C01)
            {
                seenBlack01 = true;
            }
        }
        else
        {
            if (C01.r > brightnessThreshold || C01.g > brightnessThreshold || C01.b > brightnessThreshold)
            {
                gridObjects[1].SetActive(true);
                gridObjects[1].SetActive(false);
                seenBlack01 = false;
            }
        }
        if (seenBlack02 == false)
        {
            if (Color.black == C02)
            {
                seenBlack02 = true;
            }
        }
        else
        {
            if (C02.r > brightnessThreshold || C02.g > brightnessThreshold || C02.b > brightnessThreshold)
            {
                gridObjects[2].SetActive(true);
                gridObjects[2].SetActive(false);
                seenBlack02 = false;
            }
        }
        if (seenBlack03 == false)
        {
            if (Color.black == C03)
            {
                seenBlack03 = true;
            }
        }
        else
        {
            if (C03.r > brightnessThreshold || C03.g > brightnessThreshold || C03.b > brightnessThreshold)
            {
                gridObjects[3].SetActive(true);
                gridObjects[3].SetActive(false);
                seenBlack03 = false;
            }
        }
        if (seenBlack04 == false)
        {
            if (Color.black == C04)
            {
                seenBlack04 = true;
            }
        }
        else
        {
            if (C04.r > brightnessThreshold || C04.g > brightnessThreshold || C04.b > brightnessThreshold)
            {
                gridObjects[4].SetActive(true);
                gridObjects[4].SetActive(false);
                seenBlack04 = false;
            }
        }
        if (seenBlack10 == false)
        {
            if (Color.black == C10)
            {
                seenBlack10 = true;
            }
        }
        else
        {
            if (C10.r > brightnessThreshold || C10.g > brightnessThreshold || C10.b > brightnessThreshold)
            {
                gridObjects[5].SetActive(true);
                gridObjects[5].SetActive(false);
                seenBlack10 = false;
            }
        }
        if (seenBlack11 == false)
        {
            if (Color.black == C11)
            {
                seenBlack11 = true;
            }
        }
        else
        {
            if (C11.r > brightnessThreshold || C11.g > brightnessThreshold || C11.b > brightnessThreshold)
            {
                gridObjects[6].SetActive(true);
                gridObjects[6].SetActive(false);
                seenBlack11 = false;
            }
        }
        if (seenBlack12 == false)
        {
            if (Color.black == C12)
            {
                seenBlack12 = true;
                gridObjects[7].SetActive(false);
            }
        }
        else
        {
            if (C12.r > brightnessThreshold || C12.g > brightnessThreshold || C12.b > brightnessThreshold)
            {
                gridObjects[7].SetActive(true);
                seenBlack12 = false;
            }
        }
        if (seenBlack13 == false)
        {
            if (Color.black == C13)
            {
                seenBlack13 = true;
            }
        }
        else
        {
            if (C13.r > brightnessThreshold || C13.g > brightnessThreshold || C13.b > brightnessThreshold)
            {
                gridObjects[8].SetActive(true);
                gridObjects[8].SetActive(false);
                seenBlack13 = false;
            }
        }
        if (seenBlack14 == false)
        {
            if (Color.black == C14)
            {
                seenBlack14 = true;
            }
        }
        else
        {
            if (C14.r > brightnessThreshold || C14.g > brightnessThreshold || C14.b > brightnessThreshold)
            {
                gridObjects[9].SetActive(true);
                gridObjects[9].SetActive(false);
                seenBlack14 = false;
            }
        }
        if (seenBlack20 == false)
        {
            if (Color.black == C20)
            {
                seenBlack20 = true;
            }
        }
        else
        {
            if (C20.r > brightnessThreshold || C20.g > brightnessThreshold || C20.b > brightnessThreshold)
            {
                gridObjects[10].SetActive(true);
                gridObjects[10].SetActive(false);
                seenBlack20 = false;
            }
        }
        if (seenBlack21 == false)
        {
            if (Color.black == C21)
            {
                seenBlack21 = true;
            }
        }
        else
        {
            if (C21.r > brightnessThreshold || C21.g > brightnessThreshold || C21.b > brightnessThreshold)
            {
                gridObjects[11].SetActive(true);
                gridObjects[11].SetActive(false);
                seenBlack21 = false;
            }
        }
        if (seenBlack22 == false)
        {
            if (Color.black == C22)
            {
                seenBlack22 = true;
            }
        }
        else
        {
            if (C22.r > brightnessThreshold || C22.g > brightnessThreshold || C22.b > brightnessThreshold)
            {
                gridObjects[12].SetActive(true);
                gridObjects[12].SetActive(false);
                seenBlack22 = false;
            }
        }
        if (seenBlack23 == false)
        {
            if (Color.black == C23)
            {
                seenBlack23 = true;
            }
        }
        else
        {
            if (C23.r > brightnessThreshold || C23.g > brightnessThreshold || C23.b > brightnessThreshold)
            {
                gridObjects[13].SetActive(true);
                gridObjects[13].SetActive(false);
                seenBlack23 = false;
            }
        }
        if (seenBlack24 == false)
        {
            if (Color.black == C24)
            {
                seenBlack24 = true;
            }
        }
        else
        {
            if (C24.r > brightnessThreshold || C24.g > brightnessThreshold || C24.b > brightnessThreshold)
            {
                gridObjects[14].SetActive(true);
                gridObjects[14].SetActive(false);
                seenBlack24 = false;
            }
        }
        if (seenBlack30 == false)
        {
            if (Color.black == C30)
            {
                seenBlack30 = true;
                gridObjects[15].SetActive(false);
            }
        }
        else
        {
            if (C30.r > brightnessThreshold || C30.g > brightnessThreshold || C30.b > brightnessThreshold)
            {
                gridObjects[15].SetActive(true);
                seenBlack30 = false;
            }
        }
        if (seenBlack31 == false)
        {
            if (Color.black == C31)
            {
                seenBlack31 = true;
            }
        }
        else
        {
            if (C31.r > brightnessThreshold || C31.g > brightnessThreshold || C31.b > brightnessThreshold)
            {
                gridObjects[16].SetActive(true);
                gridObjects[16].SetActive(false);
                seenBlack31 = false;
            }
        }
        if (seenBlack32 == false)
        {
            if (Color.black == C32)
            {
                seenBlack32 = true;
            }
        }
        else
        {
            if (C32.r > brightnessThreshold || C32.g > brightnessThreshold || C32.b > brightnessThreshold)
            {
                gridObjects[17].SetActive(true);
                gridObjects[17].SetActive(false);
                seenBlack32 = false;
            }
        }
        if (seenBlack33 == false)
        {
            if (Color.black == C33)
            {
                seenBlack33 = true;
            }
        }
        else
        {
            if (C33.r > brightnessThreshold || C33.g > brightnessThreshold || C33.b > brightnessThreshold)
            {
                gridObjects[18].SetActive(true);
                gridObjects[18].SetActive(false);
                seenBlack33 = false;
            }
        }
        if (seenBlack34 == false)
        {
            if (Color.black == C34)
            {
                seenBlack34 = true;
                gridObjects[19].SetActive(false);
            }
        }
        else
        {
            if (C34.r > brightnessThreshold || C34.g > brightnessThreshold || C34.b > brightnessThreshold)
            {
                gridObjects[19].SetActive(true);
                seenBlack34 = false;
            }
        }
        if (seenBlack40 == false)
        {
            if (Color.black == C40)
            {
                seenBlack40 = true;
                gridObjects[20].SetActive(false);
            }
        }
        else
        {
            if (C40.r > brightnessThreshold || C40.g > brightnessThreshold || C40.b > brightnessThreshold)
            {
                gridObjects[20].SetActive(true);
                seenBlack40 = false;
            }
        }
        if (seenBlack41 == false)
        {
            if (Color.black == C41)
            {
                seenBlack41 = true;
            }
        }
        else
        {
            if (C41.r > brightnessThreshold || C41.g > brightnessThreshold || C41.b > brightnessThreshold)
            {
                gridObjects[21].SetActive(true);
                gridObjects[21].SetActive(false);
                seenBlack41 = false;
            }
        }
        if (seenBlack42 == false)
        {
            if (Color.black == C42)
            {
                seenBlack42 = true;
            }
        }
        else
        {
            if (C42.r > brightnessThreshold || C42.g > brightnessThreshold || C42.b > brightnessThreshold)
            {
                gridObjects[22].SetActive(true);
                gridObjects[22].SetActive(false);
                seenBlack42 = false;
            }
        }
        if (seenBlack43 == false)
        {
            if (Color.black == C43)
            {
                seenBlack43 = true;
            }
        }
        else
        {
            if (C43.r > brightnessThreshold || C43.g > brightnessThreshold || C43.b > brightnessThreshold)
            {
                gridObjects[23].SetActive(true);
                gridObjects[23].SetActive(false);
                seenBlack43 = false;
            }
        }
        if (seenBlack44 == false)
        {
            if (Color.black == C44)
            {
                seenBlack44 = true;
                gridObjects[24].SetActive(false);
            }
        }
        else
        {
            if (C44.r > brightnessThreshold || C44.g > brightnessThreshold || C44.b > brightnessThreshold)
            {
                gridObjects[24].SetActive(true);
                seenBlack44 = false;
            }
        }
        if (seenBlack55 == false)
        {
            if (Color.black == C55)
            {
                seenBlack55 = true;
            }
        }
        else
        {
            if (C55.r > brightnessThreshold || C55.g > brightnessThreshold || C55.b > brightnessThreshold)
            {
                gridObjects[25].SetActive(true);
                gridObjects[25].SetActive(false);
                seenBlack55 = false;
            }
        }
    }
}
