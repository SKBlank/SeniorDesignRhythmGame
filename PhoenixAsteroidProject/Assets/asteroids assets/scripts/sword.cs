using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    void OnCollisionEnter(Collision targetObj) 
    {
        print("sword hit");
        // if(targetObj.gameObject.tag == "Enemy")
        // {
        //     targetObj.FractureObject();
        // }
    }
}

