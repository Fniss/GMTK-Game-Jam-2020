using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Transform moveableChild;
    public GameObject spawnOnMove;
    Vector3 spawnOffset;
    Driving driver;
    public bool randomX = false;
    public float triggerMoveOn, MoveForwardBy;
    // Update is called once per frame
    void Start ()
    {
        driver = FindObjectOfType<Driving>();
        spawnOffset = transform.position;
    }
    void Update()
    {
        if (driver.transform.position.y-transform.position.y > triggerMoveOn)
        {
            transform.position += Vector3.up*MoveForwardBy;
            if (randomX) transform.position = new Vector3 (Random.value*20-10, transform.position.y,transform.position.z);
            if (moveableChild != null)
            {
                moveableChild.transform.position += Vector3.up*MoveForwardBy;
            }
            if (spawnOnMove !=null)
            {
                Instantiate(spawnOnMove,transform.position-spawnOffset,Quaternion.identity);
            }
        }
    }
}
