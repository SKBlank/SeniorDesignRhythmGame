using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipCollider : MonoBehaviour
{
    public ComboHealth comboHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TrackingObject")
        {
            // Debug.Log("Hit planet");
            Destroy(other.gameObject);
            comboHealth.PlanetHit();
        }
    }
}