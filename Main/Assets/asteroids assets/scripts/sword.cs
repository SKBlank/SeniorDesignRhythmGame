using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    public ComboHealth comboHealth;
    public AudioSource swordSound;
    Vector3 startPos;
    //public Transform transform_sword = sword.transform;
    void Start() {
        startPos = transform.position;
    } 

    void Update() {
        moveLeftRight();
        moveUpDown();
    }

    void OnCollisionEnter(Collision targetObj) 
    {
        if (targetObj.gameObject.tag == "Enemy")
        {
            swordSound.Play();
            comboHealth.IncreaseCombo();
        }
    }
    
    void moveLeftRight(){
        Vector3 vecLR = Vector3.zero;
        vecLR.z = Input.GetAxis("Horizontal");
        Vector3 v = new Vector3(0.0f, 0.0f, vecLR.z) * Time.deltaTime * 15.0f;
        transform.Translate(v, Space.World);
    }    
    void moveUpDown(){
        Vector3 vecUD = Vector3.zero;
        vecUD.y = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(0.0f, vecUD.y, 0.0f) * Time.deltaTime * 15.0f;
        transform.Translate(v, Space.World);
    }    
}

