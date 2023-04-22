// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class handControllerInput : MonoBehaviour
// {
//     public float ySpeed = 5.0f; // Speed of y-axis movement
//     public float zSpeed = 5.0f; // Speed of z-axis movement
//     public GameObject targetObject; // Reference to the game object to be moved
//     public GameObject targetObject2; // Reference to the game object to be moved

//     void Update()
//     {
//         // Get input from joystick for y-axis movement
//         float yInput = Input.GetAxis("Vertical");

//         // Calculate the new position of the game object along the y-axis
//         Vector3 newPositionY = targetObject.transform.position + new Vector3(0, yInput * ySpeed * Time.deltaTime, 0);

//         // Update the position of the game object along the y-axis
//         targetObject.transform.position = newPositionY;

//         // Get input from joystick for z-axis movement
//         float zInput = Input.GetAxis("Horizontal");

//         // Calculate the new position of the game object along the z-axis
//         Vector3 newPositionZ = targetObject.transform.position + new Vector3(0, 0, zInput * zSpeed * Time.deltaTime);

//         // Update the position of the game object along the z-axis
//         targetObject.transform.position = newPositionZ;



//         // Get input from joystick for y-axis movement
//         float yInput2 = Input.GetAxis("Vertical2");

//         // Calculate the new position of the game object along the y-axis
//         Vector3 newPositionY2 = targetObject2.transform.position + new Vector3(0, yInput2 * ySpeed * Time.deltaTime, 0);

//         // Update the position of the game object along the y-axis
//         targetObject2.transform.position = newPositionY2;

//         // Get input from joystick for z-axis movement
//         float zInput2 = Input.GetAxis("Horizontal2");

//         // Calculate the new position of the game object along the z-axis
//         Vector3 newPositionZ2 = targetObject2.transform.position + new Vector3(0, 0, zInput2 * zSpeed * Time.deltaTime);

//         // Update the position of the game object along the z-axis
//         targetObject2.transform.position = newPositionZ2;
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handControllerInput : MonoBehaviour
{
    public float ySpeed = 5.0f; // Speed of y-axis movement
    public float zSpeed = 5.0f; // Speed of z-axis movement
    public GameObject targetObject; // Reference to the game object to be moved
    public GameObject targetObject2; // Reference to the game object to be moved
    public GameObject planeObject; // Reference to the game object representing the plane

    private Vector3 minBounds; // Minimum bounds for movement
    private Vector3 maxBounds; // Maximum bounds for movement

    void Start()
    {
        // Calculate the min and max bounds based on the size of the plane object
        Renderer planeRenderer = planeObject.GetComponent<Renderer>();
        minBounds = planeRenderer.bounds.min;
        maxBounds = planeRenderer.bounds.max;
    }

    void Update()
    {
        // Get input from joystick for y-axis movement
        float yInput = Input.GetAxis("Vertical");

        // Calculate the new position of the game object along the y-axis
        Vector3 newPositionY = targetObject.transform.position + new Vector3(0, yInput * ySpeed * Time.deltaTime, 0);

        // Clamp the new position within the y-axis bounds
        newPositionY.y = Mathf.Clamp(newPositionY.y, minBounds.y, maxBounds.y);

        // Update the position of the game object along the y-axis
        targetObject.transform.position = newPositionY;

        // Get input from joystick for z-axis movement
        float zInput = Input.GetAxis("Horizontal");

        // Calculate the new position of the game object along the z-axis
        Vector3 newPositionZ = targetObject.transform.position + new Vector3(0, 0, zInput * zSpeed * Time.deltaTime);

        // Clamp the new position within the z-axis bounds
        newPositionZ.z = Mathf.Clamp(newPositionZ.z, minBounds.z, maxBounds.z);

        // Update the position of the game object along the z-axis
        targetObject.transform.position = newPositionZ;


        // Get input from joystick for y-axis movement
        float yInput2 = Input.GetAxis("Vertical2");

        // Calculate the new position of the game object along the y-axis
        Vector3 newPositionY2 = targetObject2.transform.position + new Vector3(0, yInput2 * ySpeed * Time.deltaTime, 0);

        // Clamp the new position within the y-axis bounds
        newPositionY2.y = Mathf.Clamp(newPositionY2.y, minBounds.y, maxBounds.y);

        // Update the position of the game object along the y-axis
        targetObject2.transform.position = newPositionY2;

        // Get input from joystick for z-axis movement
        float zInput2 = Input.GetAxis("Horizontal2");

        // Calculate the new position of the game object along the z-axis
        Vector3 newPositionZ2 = targetObject2.transform.position + new Vector3(0, 0, zInput2 * zSpeed * Time.deltaTime);

        // Clamp the new position within the z-axis bounds
        newPositionZ2.z = Mathf.Clamp(newPositionZ2.z, minBounds.z, maxBounds.z);

        // Update the position of the game object along the z-axis
        targetObject2.transform.position = newPositionZ2;
    }
}