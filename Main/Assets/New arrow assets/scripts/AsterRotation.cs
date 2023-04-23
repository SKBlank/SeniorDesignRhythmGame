using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsterRotation : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(30.0f, 60.0f, 90.0f); // Speed of rotation in degrees per second for each axis
    public float maxRandomOffset = 10.0f; // Maximum random offset in degrees

    void Update()
    {
        // Generate random offsets for each axis
        float randomOffsetX = Random.Range(-maxRandomOffset, maxRandomOffset);
        float randomOffsetY = Random.Range(-maxRandomOffset, maxRandomOffset);
        float randomOffsetZ = Random.Range(-maxRandomOffset, maxRandomOffset);

        // Update rotation speeds with random offsets
        Vector3 randomizedRotationSpeed = rotationSpeed + new Vector3(randomOffsetX, randomOffsetY, randomOffsetZ);

        // Rotate the object around all of its axes at the updated rotation speeds
        transform.Rotate(randomizedRotationSpeed * Time.deltaTime);
    }
}