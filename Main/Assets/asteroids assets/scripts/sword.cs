using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public ComboHealth comboHealth;
    public AudioSource swordSound;

    void OnCollisionEnter(Collision targetObj) 
    {
        if (targetObj.gameObject.tag == "Enemy")
        {
            swordSound.Play();
            comboHealth.IncreaseCombo();
        }
    }
}

