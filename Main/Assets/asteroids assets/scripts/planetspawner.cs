using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetspawner : MonoBehaviour
{
    public GameObject[] planets;
    public GameObject endPoint;


    void OnEnable()
    {
        spawnPlanet();
    }

    void spawnPlanet()
    {
        // print("spawned planet");
        
        int prefabIndex = Random.Range(0, planets.Length);

        GameObject planetInstance = Instantiate(planets[prefabIndex], transform.position, Quaternion.identity);
        flyplanet flyplanet = planetInstance.GetComponent<flyplanet>();

        flyplanet.setAttractor(endPoint, transform.position);
    }
}
