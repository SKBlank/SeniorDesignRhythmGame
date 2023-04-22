// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class swordMove : MonoBehaviour
// {
//     public GameObject baseObject;   // Reference to the base object
//     public GameObject tip;    // Reference to the tip object
//     public float threshold = 0.1f;   // Threshold value to check against

//     private float initialDistance;  // Initial distance between base and tip

//     void Start()
//     {
//         // Calculate the initial distance between base and tip
//         initialDistance = Vector3.Distance(baseObject.transform.position, tip.transform.position);
//     }

//     void Update()
//     {
//         // Calculate the current distance between base and tip
//         float currentDistance = Vector3.Distance(baseObject.transform.position, tip.transform.position);

//         // Check if the current distance is greater than the threshold
//         if (currentDistance > threshold)
//         {
//             // Calculate the difference between the current distance and the threshold
//             float distanceDifference = currentDistance - threshold;

//             // Calculate the adjustment amount based on the distance difference
//             float adjustmentAmount = distanceDifference / 2;

//             // Get the direction from base to tip
//             Vector3 direction = (tip.transform.position - baseObject.transform.position).normalized;

//             // Adjust the base position on the x and z axis separately by the adjustment amount
//             Vector3 newPosition = baseObject.transform.position + (direction * adjustmentAmount);
//             newPosition.x = baseObject.transform.position.x;  // Maintain the original x position
//             baseObject.transform.position = newPosition;
//         }
//     }
// }





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordMove : MonoBehaviour
{
    public GameObject baseObject;   // Reference to the base object
    public GameObject tip;    // Reference to the tip object
    public float threshold = 0.1f;   // Threshold value to check against
    public float biasFactor = 0.5f;  // Bias factor to control the amount of bias towards starting position

    private float initialDistance;  // Initial distance between base and tip
    private Vector3 initialPosition; // Initial position of the base object

    void Start()
    {
        // Calculate the initial distance between base and tip
        initialDistance = Vector3.Distance(baseObject.transform.position, tip.transform.position);

        // Store the initial position of the base object
        initialPosition = baseObject.transform.position;
    }

    void Update()
    {
        // Calculate the current distance between base and tip
        float currentDistance = Vector3.Distance(baseObject.transform.position, tip.transform.position);

        // Check if the current distance is greater than the threshold
        if (currentDistance > threshold)
        {
            // Calculate the difference between the current distance and the threshold
            float distanceDifference = currentDistance - threshold;

            // Calculate the adjustment amount based on the distance difference
            float adjustmentAmount = distanceDifference / 2;

            // Get the direction from base to tip
            Vector3 direction = (tip.transform.position - baseObject.transform.position).normalized;

            // Adjust the base position on the x and z axis separately by the adjustment amount
            Vector3 newPosition = baseObject.transform.position + (direction * adjustmentAmount);

            // Add bias towards the initial position
            newPosition = Vector3.Lerp(newPosition, initialPosition, biasFactor);

            // Maintain the original y position
            newPosition.x = baseObject.transform.position.x;

            baseObject.transform.position = newPosition;
        }
    }
}