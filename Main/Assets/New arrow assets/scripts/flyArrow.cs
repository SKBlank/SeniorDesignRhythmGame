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

     void Start()
    {
        //find a game object named "catcher"
        catcher = GameObject.Find("catcher");
        // Set end pos y and z to the same as start pos
        // endPos.position = new Vector3(endPos.position.x, startPos.position.y, startPos.position.z);
    }


    void Update()
    {
        if(startPos == null || endPos == null)
            return;

        currentTime += Time.deltaTime;
        float t = Mathf.Clamp01(currentTime / TimeToEndPos);
        transform.position = Vector3.Lerp(startPos.position, endPos.position, t);

        if (currentTime >= TimeToEndPos)
        {
            currentTime = 0.0f;
            startPos = endPos;
            endPos = catcherPos;
        }
    }

    // Set start and end positions for the asteroid object
    public void SetStartAndEndPositions(GameObject start, GameObject end, GameObject catcher)
    {
        startPos = start.transform;
        endPos = end.transform;
        catcherPos = catcher.transform;
    }
  

    // void OnDestroy()
    // {
    //     if(startPos != null)
    //         Destroy(startPos.gameObject);
    //     if(endPos != null)
    //         Destroy(endPos.gameObject);
    // }
}