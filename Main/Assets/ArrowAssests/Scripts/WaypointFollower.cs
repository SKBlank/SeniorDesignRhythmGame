using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    GameObject[] waypoints = new GameObject[2];
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    void Start(){
        waypoints[0] = GameObject.Find("Waypoint_L");
        waypoints[1] = GameObject.Find("Waypoint_R");
    }

    // Update is called once per frame
    void Update(){
        if(Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.1f){
            if(currentWaypointIndex == waypoints.Length-1){
                currentWaypointIndex = 0;
            }else{
                currentWaypointIndex++;
            }
        }

        if(Vector3.Distance(transform.position, waypoints[1].transform.position) < 0.1f){
            Destroy(transform.gameObject);
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
