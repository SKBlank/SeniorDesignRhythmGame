using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowClickerManager : MonoBehaviour
{
    private bool keyReleased;
    public GameObject clicker;
    public KeyCode switchKey;
    public int activeFrames = 60; // Define the number of frames for which the clicker should be active

    // Start is called before the first frame update
    void Start()
    {
        clicker.SetActive(false);
        keyReleased = true;
    }

    // Update is called once per frame
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
