using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyArrow : MonoBehaviour
{
    private Transform startPos;
    private Transform endPos;
    private Transform catcherPos;
    private GameObject catcher;
    private float TimeToEndPos = 5.0f;
    private float currentTime = 0.0f;

    private float startTime;
    private float endTime;

     void Start()
    {
        catcher = GameObject.Find("catcher");
        startTime = Time.time;
    }


    void FixedUpdate()
    {
        if(startPos == null || endPos == null)
            return;

        currentTime += Time.deltaTime;
        float t = Mathf.Clamp01(currentTime / TimeToEndPos);
        transform.position = Vector3.Lerp(startPos.position, endPos.position, t);

        if (currentTime >= TimeToEndPos)
        {
            TimeToEndPos = 2.0f;
            currentTime = 0.0f;
            startPos = endPos;
            endPos = catcherPos;
        }
    }

    public void SetStartAndEndPositions(GameObject start, GameObject end, GameObject catcher)
    {
        startPos = start.transform;
        endPos = end.transform;
        catcherPos = catcher.transform;
    }

    void OnDestroy()
    {
        endTime = Time.time;
        //print("Arrow lifespan: " + (endTime - startTime));
    }
}