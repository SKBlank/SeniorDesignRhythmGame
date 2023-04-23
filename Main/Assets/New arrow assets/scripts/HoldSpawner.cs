using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldSpawner : MonoBehaviour
{
    public GameObject[] asteroids;
    public GameObject endPoint;
    public GameObject catcher;
    public int spawnFrequency = 30;
    private bool started = false;
    private int frameCount = 0; 

    void Start()
    {
    }

    void OnEnable()
    {
        // print("enabled");
        if (!started)
        {
            started = true;
            spawnAsteroid(0);
        }
    }
    
    void OnDisable()
    {
       started = false;
    //    print("disabled");
    }

    void spawnAsteroid(int prefabIndex)
    {
        GameObject asteroidInstance = Instantiate(asteroids[prefabIndex], transform.position, Quaternion.identity);
        flyArrow flyArrow = asteroidInstance.GetComponent<flyArrow>();

        flyArrow.SetStartAndEndPositions(gameObject, endPoint, catcher);
    }



    void Update()
    {
        if(started == true)
        {
            frameCount++;
            if (frameCount >= spawnFrequency)
            {
                spawnAsteroid(1);
                frameCount = 0;
            }
        }
    }
}
