using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handControllerInput : MonoBehaviour
{
    //speeds for movement
    public float ySpeed = 5.0f; 
    public float zSpeed = 5.0f; 
    
    public GameObject targetObject; 
    public GameObject targetObject2; 
    public GameObject planeObject; 

    //bounds
    private Vector3 minBounds; 
    private Vector3 maxBounds; 

    void Start()
    {
        Renderer planeRenderer = planeObject.GetComponent<Renderer>();
        minBounds = planeRenderer.bounds.min;
        maxBounds = planeRenderer.bounds.max;
    }

    void Update()
    {
        float yInput = Input.GetAxis("Vertical");
        Vector3 newPositionY = targetObject.transform.position + new Vector3(0, yInput * ySpeed * Time.deltaTime, 0);
        newPositionY.y = Mathf.Clamp(newPositionY.y, minBounds.y, maxBounds.y);
        targetObject.transform.position = newPositionY;

       
        float zInput = Input.GetAxis("Horizontal");
        Vector3 newPositionZ = targetObject.transform.position + new Vector3(0, 0, zInput * zSpeed * Time.deltaTime);
        newPositionZ.z = Mathf.Clamp(newPositionZ.z, minBounds.z, maxBounds.z);
        targetObject.transform.position = newPositionZ;


        float yInput2 = Input.GetAxis("Vertical2");
        Vector3 newPositionY2 = targetObject2.transform.position + new Vector3(0, yInput2 * ySpeed * Time.deltaTime, 0);
        newPositionY2.y = Mathf.Clamp(newPositionY2.y, minBounds.y, maxBounds.y);
        targetObject2.transform.position = newPositionY2;


        float zInput2 = Input.GetAxis("Horizontal2");
        Vector3 newPositionZ2 = targetObject2.transform.position + new Vector3(0, 0, zInput2 * zSpeed * Time.deltaTime);
        newPositionZ2.z = Mathf.Clamp(newPositionZ2.z, minBounds.z, maxBounds.z);
        targetObject2.transform.position = newPositionZ2;
    }
}