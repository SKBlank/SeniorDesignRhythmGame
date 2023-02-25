using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public ComboHealth comboHealth;

    void OnCollisionEnter(Collision targetObj) 
    {
        if (targetObj.gameObject.tag == "Enemy")
        {
            comboHealth.IncreaseCombo();
        }
    }
}

