using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetspawner : MonoBehaviour
{
    public GameObject[] planets;
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
        spawnPlanet();
    }

    void spawnPlanet()
    {
        print("spawned planet");
        // Debug.Log("spawned aster");
        // Vector3 randomPosition = new Vector3(0, Random.Range(-3, 3), Random.Range(-3, 3));
        // Vector3 randomPosition = new Vector3(0, 0, 0);
        int prefabIndex = Random.Range(0, planets.Length);

        // Instantiate(planets[prefabIndex], transform.position, Quaternion.identity);
        // Instantiate(planets[prefabIndex], randomPosition, Random.Range(0, 360) * Quaternion.identity);

        GameObject planetInstance = Instantiate(planets[prefabIndex], transform.position, Quaternion.identity);
        flyplanet flyplanet = planetInstance.GetComponent<flyplanet>();

        // Set unique start and end positions for the flyplanet script
        //star position is the current position of the asteroid
        Vector3 startPos = transform.position;

        Vector3 endPos = endPoint.transform.position;

        // flyplanet.SetStartAndEndPositions(startPos, endPos);
    }

    void Update()
    {
    }
}
