﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyasteroid : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;
    private float TimeToEndPos = 1.0f;
    private float currentTime = 0.0f;

     void Start()
    {
        // Set end pos y and z to the same as start pos
        endPos = new Vector3(endPos.x, startPos.y, startPos.z);
    }


    void Update()
    {
        currentTime += Time.deltaTime;
        float t = Mathf.Clamp01(currentTime / TimeToEndPos);
        transform.position = Vector3.Lerp(startPos, endPos, t);

        if (currentTime >= TimeToEndPos)
        {
            currentTime = 0.0f;
            startPos = endPos;
            endPos = new Vector3(endPos.x + 10, endPos.y, endPos.z);
        }
    }

    // Set start and end positions for the asteroid object
    public void SetStartAndEndPositions(Vector3 start, Vector3 end)
    {
        startPos = start;
        endPos = new Vector3(end.x, start.y, start.z);
    }
}