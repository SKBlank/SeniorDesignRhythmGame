using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiater : MonoBehaviour
{

    public GameObject objectToInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnObject()
    {
        GameObject newObject = Instantiate(objectToInstantiate, transform.position, transform.rotation);
    }
}
