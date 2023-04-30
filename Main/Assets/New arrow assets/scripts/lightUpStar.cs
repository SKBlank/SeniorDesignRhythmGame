using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightUpStar : MonoBehaviour
{
    public KeyCode switchKey;
    public GameObject[] staroutlines;
    
    void Start()
    {
        staroutlines[0].SetActive(true);
        staroutlines[1].SetActive(false);
        staroutlines[2].SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            staroutlines[0].SetActive(false);
            staroutlines[1].SetActive(true);
            staroutlines[2].SetActive(true);
        }
        if (Input.GetKeyUp(switchKey))
        {
            staroutlines[0].SetActive(true);
            staroutlines[1].SetActive(false);
            staroutlines[2].SetActive(false);
        }
    }
}
