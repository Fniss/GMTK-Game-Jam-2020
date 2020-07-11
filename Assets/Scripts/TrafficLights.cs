using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
    private BoxCollider2D coll;
    //traffic light collider
    [SerializeField] private bool red = true;
    //the traffic signal is red for drunk driver

    void Start(){
        coll = GetComponent<BoxCollider2D>();
	}

    // Update is called once per frame
    void Update()
    {
        TurnGreen();
    }

    //Turns traffic signal green for drunk driver if player clicks on traffic light
     private void TurnGreen(){
         if (Input.GetMouseButtonDown(0)) {
                 red = false;
         }
         else{
            red = true;  //turns back red if not pressed;
		 }
	}

    //checks to see if car crosses interesection on red
    private void OnTriggerEnter2D(Collider2D coll){
        if(red == true){// if it crosses on red crash and change to game over screen
          
		}
	}
}
