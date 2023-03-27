using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyasteroid : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);
        // transform.position += transform.right * Time.deltaTime * 10;
        transform.Rotate(Vector3.right * Time.deltaTime, Space.World);
    }
}
