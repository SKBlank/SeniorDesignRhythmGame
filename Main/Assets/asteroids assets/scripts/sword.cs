using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public ComboHealth comboHealth;
    public AudioSource swordSound;

    void OnTriggerEnter(Collider targetObj) 
    {
        print("Collision Detected");
        if (targetObj.gameObject.tag == "Enemy")
        {
            print("Enemy Hit");
            swordSound.Play();
            comboHealth.IncreaseCombo();
        }
    }
}

