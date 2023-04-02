using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    [SerializeField] int SpawnDelay = 3;
    [SerializeField] GameObject arrowPreFab;
    Canvas canvas;

    void Start(){
        canvas = (Canvas)GameObject.FindObjectOfType(typeof(Canvas));
        StartCoroutine(spawnArrow());
    }


    IEnumerator spawnArrow(){
        while(true){
            GameObject createdArrow = Instantiate(arrowPreFab, new Vector3(-649, -261, 0), Quaternion.identity);
            createdArrow.transform.SetParent(canvas.gameObject.transform, false);

            yield return new WaitForSeconds(SpawnDelay);
        }
    }
}
