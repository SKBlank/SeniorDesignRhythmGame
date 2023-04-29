using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordMove : MonoBehaviour
{
    public GameObject baseObject;   
    public GameObject tip;    

    //checks if the sword is in the right position
    public float threshold = 0.1f;   
    public float biasFactor = 0.5f;  

    //position to return to
    private float initialDistance;  
    private Vector3 initialPosition; 

    void Start()
    {
        // Calculate the initial distance between base and tip
        initialDistance = Vector3.Distance(baseObject.transform.position, tip.transform.position);
        initialPosition = baseObject.transform.position;
    }

    void Update()
    {
        float currentDistance = Vector3.Distance(baseObject.transform.position, tip.transform.position);

        // Check if the current distance is greater than the threshold
        if (currentDistance > threshold)
        {
            float distanceDifference = currentDistance - threshold;
            float adjustmentAmount = distanceDifference / 2;

            Vector3 direction = (tip.transform.position - baseObject.transform.position).normalized;
            Vector3 newPosition = baseObject.transform.position + (direction * adjustmentAmount);

            newPosition = Vector3.Lerp(newPosition, initialPosition, biasFactor);
            newPosition.x = baseObject.transform.position.x;
            baseObject.transform.position = newPosition;
        }
    }
}