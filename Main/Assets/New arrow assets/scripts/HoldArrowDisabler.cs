using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldArrowDisabler : MonoBehaviour
{
    void OnTriggerEnter(Collider arrow)
    {
        if (arrow.gameObject.tag == "HoldArrow")
        {
            arrow.gameObject.tag = "Enemy";
        }
    }
}
