using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript : BaseObstacle
{
Rigidbody2D rb2d;
public Transform[] wayPoints;
public Vector3 startPosition;
float trainDriveSpeed = 0.1f;
public float trainDriveSpeedValue = 0.1f;
int wayPointReached = 0;

    void Start() {

        startPosition = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
    if (wayPointReached == wayPoints.Length)
    {
        wayPointReached = 0;
        transform.position = startPosition;
        ResetSpeed();
        if (!hasDoneDamage)
        {
                FindObjectOfType<PlayerHealth>().currentPoints+= pointsValue;
        }
        hasDoneDamage = false;
    }

    if (Vector2.Distance(transform.position, wayPoints[wayPointReached].position) < 3f)
    {
    wayPointReached++;
    } else {
    transform.position = Vector2.MoveTowards(transform.position, wayPoints[wayPointReached].position, trainDriveSpeed);
    }
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
