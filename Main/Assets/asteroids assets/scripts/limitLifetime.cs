using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitLifetime : MonoBehaviour
{
    void Update ()
    {
       Destroy (gameObject, 2); //how many seconds you want before the object deletes itself
    }
}
