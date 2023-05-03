using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    [Tooltip("\"Fractured\" is the object that this will break into")]
    public GameObject fractured;
    public void FractureObject()
    {
        Instantiate(fractured, transform.position, transform.rotation); 
        Destroy(gameObject); 
    }

    bool isCurrentlyColliding;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sword")
        {
            isCurrentlyColliding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "sword")
        {
            isCurrentlyColliding = false;
        }
    }

    void Update()
    {
        if (isCurrentlyColliding)
        {
            FractureObject();

            //get object "score system" and call "IncreaseCombo" method
            GameObject.Find("score system").GetComponent<ComboHealth>().IncreaseCombo();
        }
    }
}
