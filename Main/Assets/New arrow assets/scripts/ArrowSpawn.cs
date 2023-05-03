using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    public GameObject[] asteroids;
    public GameObject endPoint;
    public GameObject catcher;


    void OnEnable()
    {
        spawnAsteroid();
    }

    void spawnAsteroid()
    {
        int prefabIndex = Random.Range(0, asteroids.Length);

        GameObject asteroidInstance = Instantiate(asteroids[prefabIndex], transform.position, Quaternion.identity);
        flyArrow flyArrow = asteroidInstance.GetComponent<flyArrow>();

        flyArrow.SetStartAndEndPositions(gameObject, endPoint, catcher);
    }
}
