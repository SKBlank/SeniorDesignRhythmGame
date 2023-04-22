using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public ComboHealth comboHealth;
    public AudioSource swordSound;

    void OnTriggerEnter(Collider targetObj) 
    {
        if (targetObj.gameObject.tag == "Enemy")
        {
            swordSound.Play();
            comboHealth.IncreaseCombo();
        }
    }
}

