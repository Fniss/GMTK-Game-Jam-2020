using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{
bool canStopCar = true;
bool canMove = true;
public Transform wayPoint1;
public Transform wayPoint2;
int currentWaypoint;
public float driveSpeed;

    void OnMouseDown()
    {
    if (canStopCar)
    canMove = false;
    }
    void Update()
    {
    if (canMove)
    {
    switch (currentWaypoint)
    {
    case 1:
    transform.position = Vector2.MoveTowards(transform.position, wayPoint1.position, driveSpeed);
    break;
    case 2:
    transform.position = Vector2.MoveTowards(transform.position, wayPoint2.position, driveSpeed);
    break;
    }
    }
    if (transform.position == wayPoint1.position || transform.position == wayPoint2.position)
    {
    switch (currentWaypoint)
    {
    case 1:
    currentWaypoint++;
    break;
    case 2:
    currentWaypoint--;
    break;
    }
    }
    }


}
