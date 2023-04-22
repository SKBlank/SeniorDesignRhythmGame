using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidspawn : MonoBehaviour
{
    public GameObject[] asteroids;
    public GameObject endPoint;

    void Start()
    {
        // print("started aster spawn")
        // InvokeRepeating("spawnAsteroid", 1f, 3f);
        //spawn one asteroid
        // spawnAsteroid();
    }

    void OnEnable()
    {
        spawnAsteroid();
    }

    void spawnAsteroid()
    {
        // print("spawned aster");
        // Debug.Log("spawned aster");
        // Vector3 randomPosition = new Vector3(0, Random.Range(-3, 3), Random.Range(-3, 3));
        // Vector3 randomPosition = new Vector3(0, 0, 0);
        int prefabIndex = Random.Range(0, asteroids.Length);

        // Instantiate(asteroids[prefabIndex], transform.position, Quaternion.identity);
        // Instantiate(asteroids[prefabIndex], randomPosition, Random.Range(0, 360) * Quaternion.identity);

        GameObject asteroidInstance = Instantiate(asteroids[prefabIndex], transform.position, Quaternion.identity);
        flyasteroid flyasteroid = asteroidInstance.GetComponent<flyasteroid>();

        // Set unique start and end positions for the flyasteroid script
        //star position is the current position of the asteroid
        Vector3 startPos = transform.position;

        Vector3 endPos = endPoint.transform.position;

        flyasteroid.SetStartAndEndPositions(startPos, endPos);
    }

    void Update()
    {
    }
}
