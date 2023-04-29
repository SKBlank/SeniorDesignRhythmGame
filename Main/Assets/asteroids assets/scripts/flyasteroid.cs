using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyasteroid : MonoBehaviour
{
    private Transform startPos;
    private Transform endPos;
    private float TimeToEndPos = 5.0f;
    private float currentTime = 0.0f;

    private float startTime;
    private float endTime;
    private float lifespan;

     void Start()
    {
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
            currentTime = 0.0f;
            startPos.position = endPos.position;
            endPos.position = new Vector3(endPos.position.x + 30, endPos.position.y, endPos.position.z);
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

    void OnDestroy()
    {
        endTime = Time.time;
        lifespan = endTime - startTime;
        print("Asteroid lifespan: " + lifespan);
        if(startPos != null)
            Destroy(startPos.gameObject);
        if(endPos != null)
            Destroy(endPos.gameObject);
    }
}