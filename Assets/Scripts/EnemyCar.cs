using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{
bool canStopCar = true;
public bool canMove = true;
public Transform wayPoint1;
public Transform wayPoint2;
int currentWaypoint = 1;


public float driveSpeed;


    void OnMouseDown()
    {
    if (canStopCar)
    StopCar();
    }
    void Update()
    {
    if (transform.position == wayPoint1.position)
    currentWaypoint++;
    else if (transform.position == wayPoint2.position)
    currentWaypoint--;

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
    }
    void StopCar()
    {
    canMove = false;
    Invoke("StartCar", Random.Range(2f, 5f));
    }
    void StartCar()
    {
    canMove = true;
    }
}
