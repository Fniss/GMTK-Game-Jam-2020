using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   //attach to drunk driver
    public int currentHealth = 10;
    public int maxHealth = 10;
   
    private BoxCollider2D coll;

    private void Start(){
        coll = GetComponent<BoxCollider2D>();
        
	}
     
    void OnTriggerEnter2D(Collider2D other)
    {
    if (other.CompareTag("StillObstacles"))
    {
    currentHealth -= other.GetComponent<StillObstacles>().damage;
    Debug.Log("We hit an obstacle!");
    }
    }

}
