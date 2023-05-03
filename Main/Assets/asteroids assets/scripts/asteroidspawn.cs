using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidspawn : MonoBehaviour
{
    public GameObject[] asteroids;
    public GameObject endPoint;


    void OnEnable()
    {
        spawnAsteroid();
    }

    void spawnAsteroid()
    {
        int prefabIndex = Random.Range(0, asteroids.Length);

        GameObject asteroidInstance = Instantiate(asteroids[prefabIndex], transform.position, Quaternion.identity);
        flyasteroid flyasteroid = asteroidInstance.GetComponent<flyasteroid>();

        Vector3 startPos = transform.position;

        Vector3 endPos = endPoint.transform.position;

        flyasteroid.SetStartAndEndPositions(startPos, endPos);
    }
}
