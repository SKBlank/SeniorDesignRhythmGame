using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowClicker : MonoBehaviour
{
    public ComboHealth comboHealth;

    void OnTriggerEnter(Collider arrow)
    {
        if (arrow.gameObject.tag == "Arrow")
        {
            float distance = Vector3.Distance(arrow.transform.position, transform.position);
            // print("Distance: " + distance);
            comboHealth.IncreaseCombo();
            // print(arrow.gameObject.name + " clicked");
            Destroy(arrow.gameObject);
        }
    }
}
