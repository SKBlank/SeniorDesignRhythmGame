using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyasteroid : MonoBehaviour
{
    private Transform startPos;
    private Transform endPos;
    private float TimeToEndPos = 1.0f;
    private float currentTime = 0.0f;

     void Start()
    {
        // Set end pos y and z to the same as start pos
        endPos.position = new Vector3(endPos.position.x, startPos.position.y, startPos.position.z);
    }


    void Update()
    {
        currentTime += Time.deltaTime;
        float t = Mathf.Clamp01(currentTime / TimeToEndPos);
        transform.position = Vector3.Lerp(startPos.position, endPos.position, t);

        if (currentTime >= TimeToEndPos)
        {
            currentTime = 0.0f;
            startPos.position = endPos.position;
            endPos.position = new Vector3(endPos.position.x + 10, endPos.position.y, endPos.position.z);
        }
    }

    // Set start and end positions for the asteroid object
    public void SetStartAndEndPositions(Vector3 start, Vector3 end)
    {
        startPos = new GameObject().transform;
        startPos.position = start;
        endPos = new GameObject().transform;
        endPos.position = new Vector3(end.x, start.y, start.z);
    }
}