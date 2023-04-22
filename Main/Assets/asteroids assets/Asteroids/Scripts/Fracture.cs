// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Fracture : MonoBehaviour
// {
//     [Tooltip("\"Fractured\" is the object that this will break into")]
//     public GameObject fractured;

//     // Pass the original asteroid's position as an argument
//     public void FractureObject(Vector3 originalPosition, Quaternion originalRotation)
//     {
//         Instantiate(fractured, originalPosition, originalRotation); //Spawn in the broken version
//         Destroy(gameObject); //Destroy the object to stop it getting in the way
//     }

//     bool isCurrentlyColliding;
     
//     void OnCollisionEnter(Collision col) 
//     {
//         if(col.gameObject.tag == "sword")
//         {
//             isCurrentlyColliding = true;
//         }
//     }
     
//     void OnCollisionExit(Collision col) 
//     {
//         if(col.gameObject.tag == "sword")
//         {
//             isCurrentlyColliding = false;
//         }
//     }
     
//     void Update() 
//     {
//         if (isCurrentlyColliding) 
//         {
//           // Vector3 temp = Vector3(0, 0, 0);
//           //create a temporary vector3 to store the original position
//           Vector3 temp = new Vector3(0, 0, 0);

//             // Pass the original asteroid's position to FractureObject()
//           FractureObject(temp, transform.rotation);
//         }
//     }
// }




// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Fracture : MonoBehaviour
// {
//     [Tooltip("\"Fractured\" is the object that this will break into")]
//     public GameObject fractured;
//     public void FractureObject()
//     {
//         Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version

//         Destroy(gameObject); //Destroy the object to stop it getting in the way
//     }

//     bool isCurrentlyColliding;
     
//     void OnCollisionEnter(Collision col) 
//     {
//         if(col.gameObject.tag == "sword")
//         {
//             isCurrentlyColliding = true;
//         }
//     }
     
//     void OnCollisionExit(Collision col) 
//     {
//       if(col.gameObject.tag == "sword")
//         {
//             isCurrentlyColliding = false;
//         }
//     }
     
//     void Update() 
//     {
//       if (isCurrentlyColliding) 
//       {
//         FractureObject();
//       }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    [Tooltip("\"Fractured\" is the object that this will break into")]
    public GameObject fractured;
    public void FractureObject()
    {
        Instantiate(fractured, transform.position, transform.rotation); //Spawn in the broken version
        Destroy(gameObject); //Destroy the object to stop it getting in the way
    }

    bool isCurrentlyColliding;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sword")
        {
            isCurrentlyColliding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "sword")
        {
            isCurrentlyColliding = false;
        }
    }

    void Update()
    {
        if (isCurrentlyColliding)
        {
            FractureObject();
        }
    }
}
