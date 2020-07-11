using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript : MonoBehaviour
{
public Transform[] wayPoints;
float trainDriveSpeed = 3f;
public float trainDriveSpeedValue = 3f;
int wayPointReached = 0;

    void Update()
    {
    trainDriveSpeed = Mathf.Clamp(trainDriveSpeed, 0f, 7f);
    if (wayPointReached == wayPoints.Length)
    wayPointReached = 0;
    if (transform.position == wayPoints[wayPointReached].position)
    wayPointReached++;
    else
    transform.position = Vector2.MoveTowards(transform.position, wayPoints[wayPointReached].position, trainDriveSpeed * Time.deltaTime);
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
