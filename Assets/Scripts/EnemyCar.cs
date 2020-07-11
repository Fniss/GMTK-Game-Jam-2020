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
public SpriteRenderer lockSprite;

private void Start(){
    lockSprite = GetComponent<SpriteRenderer>();
}

public float driveSpeed;


    void OnMouseDown()
    {
    if (canStopCar)
    StopCar();
    }
    void Update()
    {
    if (transform.position == wayPoint1.position){
    currentWaypoint++;
    lockSprite.enabled = false;
    }
    else if (transform.position == wayPoint2.position){
    currentWaypoint--;
    lockSprite.enabled = true;
    }
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
