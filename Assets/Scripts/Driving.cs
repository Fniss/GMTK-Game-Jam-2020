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
    if (currentWayPointIndex == waypoints.Length)
    currentWayPointIndex = 0;
    else {
    if (transform.position == waypoints[currentWayPointIndex].position)
    ReachNextWaypoint();
    else
    transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWayPointIndex].position, driveSpeed * Time.deltaTime);
    }
    }
    void ReachNextWaypoint()
    {
    Debug.Log("Waypoint " + currentWayPointIndex.ToString() + " reached!");
    currentWayPointIndex++;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
    if (other.gameObject.tag == "Obstacle")
    Die();
    }
    void Die()
    {
    Debug.Log("Tragically, the car crashed!");
    Destroy(gameObject);
    }

}
