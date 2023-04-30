using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinkingArrow : MonoBehaviour
{
    public GameObject arrow;
    public float blinkTime = 0.2f;
    private float timer = 0.0f;
    private bool isBlinking = true;

    void Update()
    {
        if (isBlinking)
        {
            timer += Time.deltaTime;
            if (timer >= blinkTime)
            {
                timer = 0.0f;
                arrow.SetActive(!arrow.activeSelf);
            }
        }
    }
}
