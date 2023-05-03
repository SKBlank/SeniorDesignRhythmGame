using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidCatcher : MonoBehaviour
{
    public ComboHealth comboHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy"|| other.gameObject.tag == "Arrow")
        {
            Destroy(other.gameObject);

            comboHealth.ResetCombo();
            comboHealth.DecreaseHealth();
        }
    }
}
