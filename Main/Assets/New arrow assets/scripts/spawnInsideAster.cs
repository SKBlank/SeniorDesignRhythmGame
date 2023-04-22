using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnInsideAster : MonoBehaviour
{
    public GameObject[] prefabs; // Array of prefabs to spawn

    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        // Randomly select a prefab from the array
        GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];

        // Instantiate the selected prefab as a child of this object
        GameObject spawnedObject = Instantiate(prefab, transform.position, transform.rotation, transform);

        // Set the spawned object's position and rotation relative to this object
        spawnedObject.transform.localPosition = Vector3.zero;
        spawnedObject.transform.localRotation = Quaternion.identity;
    }
}