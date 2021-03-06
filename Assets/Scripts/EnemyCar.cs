﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : BaseObstacle
{
bool canStopCar = true;
public float stopDistance;
public bool canMove = true;
public Transform wayPoint1;
public Transform wayPoint2;
int currentWaypoint = 1;
public SpriteRenderer lockSprite;
private BoxCollider2D coll;
public float timer, lifetime;

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
        timer += Time.deltaTime;

        if (timer > lifetime)
        { 
            if (!hasDoneDamage)
                FindObjectOfType<PlayerHealth>().currentPoints+= pointsValue;
            Destroy (gameObject);
        }
        RaycastHit2D[] hit2Ds = new RaycastHit2D[2];
        if (Physics2D.Raycast(transform.position,transform.up,new ContactFilter2D(), hit2Ds,stopDistance)>1)
        {
            foreach (var h in hit2Ds)
            {
                if (h.collider.transform != transform)
                    StopCar();
            }
        }
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
