using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidspawn : MonoBehaviour
{
    public GameObject[] asteroids;

    void Start()
    {
        // print("started aster spawn")
        InvokeRepeating("spawnAsteroid", 1f, 3f);
    }

    void spawnAsteroid()
    {
        print("spawned aster");
        // Debug.Log("spawned aster");
        Vector3 randomPosition = new Vector3(0, Random.Range(-3, 3), Random.Range(-3, 3));
        int prefabIndex = Random.Range(0, asteroids.Length);

        Instantiate(asteroids[prefabIndex], randomPosition, Quaternion.identity);
        // Instantiate(asteroids[prefabIndex], randomPosition, Random.Range(0, 360) * Quaternion.identity);
    }

    void Update()
    {
    }
}
