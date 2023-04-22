using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyplanet : MonoBehaviour
{
    private GameObject attractor;
    private Vector3 startPos;
    private float TimeToEndPos = 7.0f;
    private float currentTime = 0.0f;
    private Vector3 newScale = new Vector3(5.0F, 5.0F, 5.0F);



    void start()
    {

    }


    void Update()
    {
        currentTime += Time.deltaTime;
        float t = Mathf.Clamp01(currentTime / TimeToEndPos);
        transform.position = Vector3.Lerp(startPos, attractor.transform.position, t);
        transform.localScale = Vector3.Lerp(transform.localScale, newScale, t);

        if (currentTime >= TimeToEndPos)
        {
            //destroy planet
            Destroy(gameObject);
        }
    }


    public void setAttractor(GameObject attractor, Vector3 startPos)
    {
        this.attractor = attractor;
        this.startPos = startPos;
    }
}