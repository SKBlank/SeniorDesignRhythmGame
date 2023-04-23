using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldArrowClicker : MonoBehaviour
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
            float distance = Vector3.Distance(arrow.transform.position, transform.position);
            // print("Distance: " + distance);

            // print(arrow.gameObject.name + " clicked");
            Destroy(arrow.gameObject);
        }
    }
}
