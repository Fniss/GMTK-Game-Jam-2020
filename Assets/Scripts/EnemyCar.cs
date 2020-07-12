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
private BoxCollider2D coll;

public bool goingUp;
private void Start(){
    lockSprite = GetComponent<SpriteRenderer>();
    coll = GetComponent<BoxCollider2D>();
}

public float driveSpeed;


    void OnMouseDown()
    {
    if (canStopCar)
    StopCar();
    }
    void Update()
    {	
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Time.timeScale = 0; - pauses drunk driver's car
            StopCar(); 
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Time.timeScale = 1;
            canMove = true;
        }



    // if (transform.position == wayPoint1.position){
    // currentWaypoint++;
    
    // // coll.enabled = false;
    // }
    // else if (transform.position == wayPoint2.position){
    // currentWaypoint--;
    // lockSprite.enabled = true;
    // coll.enabled = true;
    // Destroy(gameObject);
    // }
    if (canMove)
    {
    // switch (currentWaypoint)
    // {
    // case 1:
    // transform.position = Vector2.MoveTowards(transform.position, wayPoint1.position, driveSpeed);
    // break;
    // case 2:
    // transform.position = Vector2.MoveTowards(transform.position, wayPoint2.position, driveSpeed);
    // break;
    // }
        if (goingUp)
            transform.position += Vector3.up* driveSpeed*Time.deltaTime;
        else
            transform.position += Vector3.down* driveSpeed*Time.deltaTime;
    }
    }
    void StopCar()
    {
    canMove = false;
    //Invoke("StartCar", Random.Range(2f, 5f));
    }
    void StartCar()
    {
    canMove = true;
    }
}
