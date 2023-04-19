using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSampler : MonoBehaviour
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
    private UnityEngine.Video.VideoPlayer videoPlayerScript;

    public RenderTexture renderTexture;

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
    public Color LastSampled22;
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


    // We need to store the Instantiater script so we can call its spawnObject() function
    private Instantiater instantiaterScript;
   
    // Start is called before the first frame update
    void Start()
    {
        videoPlayerScript = videoPlayer.GetComponent<VideoPlayer>();

        // Find the Instantiater script
        instantiaterScript = GameObject.Find("Instantiater").GetComponent<Instantiater>();

        if (instantiaterScript == null)
        {
            Debug.Log("Could not find Instantiater script");
        }
    }

    // Update is called once per frame
    void Update()
    {
        long currentFrame = videoPlayerScript.frame;
        //Debug.Log("Sampling:" + currentFrame);
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
        Color C22 = tex.GetPixel(63, 63);
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


        if (C00 != LastSampled00)
        {
            LastSampled00 = C00;
            if (C00 != Color.black)
            {
                triggerEvent(00);
            }
        }
        if (C01 != LastSampled01)
        {
            LastSampled01 = C01;
            if (C01 != Color.black)
            {
                triggerEvent(01);
            }
        }
        if (C02 != LastSampled02)
        {
            LastSampled02 = C02;
            if (C02 != Color.black)
            {
                triggerEvent(02);
            }
        }
        if (C03 != LastSampled03)
        {
            LastSampled03 = C03;
            if (C03 != Color.black)
            {
                triggerEvent(03);
            }
        }
        if (C04 != LastSampled04)
        {
            LastSampled04 = C04;
            if (C04 != Color.black)
            {
                triggerEvent(04);
            }
        }
        if (C10 != LastSampled10)
        {
            LastSampled10 = C10;
            if (C10 != Color.black)
            {
                triggerEvent(10);
            }
        }
        if (C11 != LastSampled11)
        {
            LastSampled11 = C11;
            if (C11 != Color.black)
            {
                triggerEvent(11);
            }
        }
        if (C12 != LastSampled12)
        {
            LastSampled12 = C12;
            if (C12 != Color.black)
            {
                triggerEvent(12);
            }
        }
        if (C13 != LastSampled13)
        {
            LastSampled13 = C13;
            if (C13 != Color.black)
            {
                triggerEvent(13);
            }
        }
        if (C14 != LastSampled14)
        {
            LastSampled14 = C14;
            if (C14 != Color.black)
            {
                triggerEvent(14);
            }
        }
        if (C20 != LastSampled20)
        {
            LastSampled20 = C20;
            if (C20 != Color.black)
            {
                triggerEvent(20);
            }
        }
        if (C21 != LastSampled21)
        {
            LastSampled21 = C21;
            if (C21 != Color.black)
            {
                triggerEvent(21);
            }
        }
        if (C22 != LastSampled22)
        {
            LastSampled22 = C22;
            if (C22 != Color.black)
            {
                triggerEvent(22);
            }
        }
        if (C23 != LastSampled23)
        {
            LastSampled23 = C23;
            if (C23 != Color.black)
            {
                triggerEvent(23);
            }
        }
        if (C24 != LastSampled24)
        {
            LastSampled24 = C24;
            if (C24 != Color.black)
            {
                triggerEvent(24);
            }
        }
        if (C30 != LastSampled30)
        {
            LastSampled30 = C30;
            if (C30 != Color.black)
            {
                triggerEvent(30);
            }
        }
        if (C31 != LastSampled31)
        {
            LastSampled31 = C31;
            if (C31 != Color.black)
            {
                triggerEvent(31);
            }
        }
        if (C32 != LastSampled32)
        {
            LastSampled32 = C32;
            if (C32 != Color.black)
            {
                triggerEvent(32);
            }
        }
        if (C33 != LastSampled33)
        {
            LastSampled33 = C33;
            if (C33 != Color.black)
            {
                triggerEvent(33);
            }
        }
        if (C34 != LastSampled34)
        {
            LastSampled34 = C34;
            if (C34 != Color.black)
            {
                triggerEvent(34);
            }
        }
        if (C40 != LastSampled40)
        {
            LastSampled40 = C40;
            if (C40 != Color.black)
            {
                triggerEvent(40);
            }
        }
        if (C41 != LastSampled41)
        {
            LastSampled41 = C41;
            if (C41 != Color.black)
            {
                triggerEvent(41);
            }
        }
        if (C42 != LastSampled42)
        {
            LastSampled42 = C42;
            if (C42 != Color.black)
            {
                triggerEvent(42);
            }
        }
        if (C43 != LastSampled43)
        {
            LastSampled43 = C43;
            if (C43 != Color.black)
            {
                triggerEvent(43);
            }
        }
        if (C44 != LastSampled44)
        {
            LastSampled44 = C44;
            if (C44 != Color.black)
            {
                triggerEvent(44);
            }
        }



   }

   void triggerEvent(int coord)
   {
    switch(coord)
    {
        case 00:
            Debug.Log("00");
      
            gridObjects[0].SetActive(true);
            gridObjects[0].SetActive(false);
            break;
        case 01:
            Debug.Log("01");

            gridObjects[1].SetActive(true);
            gridObjects[1].SetActive(false);
            break;  
        case 02:
            Debug.Log("02");
          
            gridObjects[2].SetActive(true);
            gridObjects[2].SetActive(false);
            break;
        case 03:
            Debug.Log("03");
          
            gridObjects[3].SetActive(true);
            gridObjects[3].SetActive(false);
            break;
        case 04:
            Debug.Log("04");
          
            gridObjects[4].SetActive(true);
            gridObjects[4].SetActive(false);
            break;
        case 10:
            Debug.Log("10");
          
            gridObjects[5].SetActive(true);
            gridObjects[5].SetActive(false);
            break;
        case 11:
            Debug.Log("11");
          
            gridObjects[6].SetActive(true);
            gridObjects[6].SetActive(false);
            break;
        case 12:
            Debug.Log("12");
          
            gridObjects[7].SetActive(true);
            gridObjects[7].SetActive(false);
            break;
        case 13:
            Debug.Log("13");
          
            gridObjects[8].SetActive(true);
            gridObjects[8].SetActive(false);
            break;
        case 14:
            Debug.Log("14");
          
            gridObjects[9].SetActive(true);
            gridObjects[9].SetActive(false);
            break;
        case 20:
            Debug.Log("20");
          
            gridObjects[10].SetActive(true);
            gridObjects[10].SetActive(false);
            break;
        case 21:
            Debug.Log("21");
          
            gridObjects[11].SetActive(true);
            gridObjects[11].SetActive(false);
            break;
        case 22:
            Debug.Log("22");
          
            gridObjects[12].SetActive(true);
            gridObjects[12].SetActive(false);
            break;
        case 23:
            Debug.Log("23");
          
            gridObjects[13].SetActive(true);
            gridObjects[13].SetActive(false);
            break;
        case 24:    
            Debug.Log("24");
          
            gridObjects[14].SetActive(true);
            gridObjects[14].SetActive(false);
            break;
        case 30:
            Debug.Log("30");
          
            gridObjects[15].SetActive(true);
            gridObjects[15].SetActive(false);
            break;
        case 31:
            Debug.Log("31");
          
            gridObjects[16].SetActive(true);
            gridObjects[16].SetActive(false);
            break;
        case 32:
            Debug.Log("32");
          
            gridObjects[17].SetActive(true);
            gridObjects[17].SetActive(false);
            break;
        case 33:
            Debug.Log("33");
          
            gridObjects[18].SetActive(true);
            gridObjects[18].SetActive(false);
            break;
        case 34:
            Debug.Log("34");
          
            gridObjects[19].SetActive(true);
            gridObjects[19].SetActive(false);
            break;
        case 40:
            Debug.Log("40");
          
            gridObjects[20].SetActive(true);
            gridObjects[20].SetActive(false);
            break;
        case 41:
            Debug.Log("41");
          
            gridObjects[21].SetActive(true);
            gridObjects[21].SetActive(false);
            break;
        case 42:
            Debug.Log("42");
          
            gridObjects[22].SetActive(true);
            gridObjects[22].SetActive(false);
            break;
        case 43:
            Debug.Log("43");
          
            gridObjects[23].SetActive(true);
            gridObjects[23].SetActive(false);
            break;
        case 44:
            Debug.Log("44");
          
            gridObjects[24].SetActive(true);
            gridObjects[24].SetActive(false);
            break;
        default:
            Debug.Log("Invalid Coordinate");
            break;
    }
   }
}
