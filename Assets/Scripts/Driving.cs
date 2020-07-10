using UnityEngine;

public class Driving : MonoBehaviour
{
[SerializeField]
Transform[] waypoints;
//  SPEED
[SerializeField]
float driveSpeed;
//  This int is the current waypoint's index.
int currentWayPointIndex = 0;



    void Update()
    {
    if (transform.position == waypoints[currentWayPointIndex].position)
    ReachNextWaypoint();
    else
    transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWayPointIndex].position, driveSpeed * Time.deltaTime);
    }
    void ReachNextWaypoint()
    {
    Debug.Log("Waypoint " + currentWayPointIndex.ToString() + " reached!");
    currentWayPointIndex++;
    }


}
