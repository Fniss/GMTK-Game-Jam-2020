using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript : MonoBehaviour
{
Rigidbody2D rb2d;
public Transform[] wayPoints;
float trainDriveSpeed = 3f;
public float trainDriveSpeedValue = 3f;
int wayPointReached = 0;

    void Start() => rb2d = GetComponent<Rigidbody2D>();


    void Update()
    {
    trainDriveSpeed = Mathf.Clamp(trainDriveSpeed, 0f, 7f);
    if (wayPointReached == wayPoints.Length)
    wayPointReached = 0;
    if (transform.position == wayPoints[wayPointReached].position)
    wayPointReached++;
    else
    transform.position = Vector2.MoveTowards(transform.position, wayPoints[wayPointReached].position, trainDriveSpeed * Time.deltaTime);
    if (wayPointReached == wayPoints.Length)
    wayPointReached = 0;
    Vector3 dir = wayPoints[wayPointReached].position;
    dir = dir - transform.position;
    float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    rb2d.rotation = (angle - 90f);
    }
    void OnMouseOver()
    {
    if (Input.GetMouseButtonDown(0))
    {
    //  Player is left clicking
    trainDriveSpeed++;    
    Invoke("ResetSpeed", 5f);
    } else if (Input.GetMouseButtonDown(1))
    {
    //  Player is right clicking
    trainDriveSpeed--;
    Invoke("ResetSpeed", 3f);
    }
    }
    void ResetSpeed()
    {
    trainDriveSpeed = trainDriveSpeedValue;
    }
    
}
