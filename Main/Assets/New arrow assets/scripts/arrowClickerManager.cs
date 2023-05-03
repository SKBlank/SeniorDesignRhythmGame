using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowClickerManager : MonoBehaviour
{
    private bool keyReleased;
    public GameObject clicker;
    public KeyCode switchKey;
    public int activeFrames = 60; // the number of frames for which the clicker should be active

    void Start()
    {
        clicker.SetActive(false);
        keyReleased = true;
    }

    void Update()
    {
        if (Input.GetKey(switchKey))
        {
            if (keyReleased)
            {
                StartCoroutine(ActivateClicker());
                keyReleased = false;
            }
        }
        else
        {
            keyReleased = true;
        }
    }

    IEnumerator ActivateClicker()
    {
        clicker.SetActive(true);
        int frames = 0;
        while (frames < activeFrames)
        {
            yield return null;
            frames++;
        }
        clicker.SetActive(false);
    }
}
