using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldArrowDisabler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider arrow)
    {
        // print("Arrow clicked");

        if (arrow.gameObject.tag == "HoldArrow")
        {
            // print("Distance: " + distance);

            // print(arrow.gameObject.name + " clicked");
            //change tagt to Enemy
            arrow.gameObject.tag = "Enemy";
        }
    }
}
