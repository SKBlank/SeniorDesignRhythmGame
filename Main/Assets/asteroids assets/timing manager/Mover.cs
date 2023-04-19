using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 direction = Vector3.forward;
    public float maxLife = 5.0f;
    private float life = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life += Time.deltaTime;

        transform.position += direction * speed * Time.deltaTime;
        
        if (life > maxLife)
        {
            Destroy(gameObject);
        }
    }
}
