using UnityEngine;

public class Driving : MonoBehaviour
{
Rigidbody2D rb2d;
[SerializeField]
Transform[] waypoints;
//  SPEED
[SerializeField]
float driveSpeed, rotationSpeed;
//  This int is the current waypoint's index.
int currentWayPointIndex = 0;

    void Start() => rb2d = GetComponent<Rigidbody2D>();

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
    LookTowardsWayPoint();
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
    void LookTowardsWayPoint()
    {
    if (currentWayPointIndex == waypoints.Length)
    currentWayPointIndex = 0;
    Vector3 dir = waypoints[currentWayPointIndex].position;
    dir = dir - transform.position;
    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    rb2d.rotation = Mathf.Lerp(rb2d.rotation,(angle - 90f),Time.deltaTime*rotationSpeed);
    }


}
