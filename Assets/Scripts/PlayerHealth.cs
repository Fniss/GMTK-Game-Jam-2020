using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   //attach to drunk driver
    public int currentHealth = 10;
    public int maxHealth = 10;
    private StillObstacles stillObstacles;
    private BoxCollider2D coll;

    private void Start(){
        coll = GetComponent<BoxCollider2D>();
        stillObstacles = GetComponent<StillObstacles>();
	}
     
     private void Update(){
        OnTriggerEnter2D();
	 }
    private void OnTriggerEnter2D(){
        if(gameObject.tag == "StillObstacles")
            currentHealth = currentHealth - stillObstacles.damage;
	}
}
