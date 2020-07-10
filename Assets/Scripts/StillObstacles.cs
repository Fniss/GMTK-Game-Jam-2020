using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StillObstacles : MonoBehaviour
{
    private BoxCollider2D coll; 

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //if car is hit lose damage
    private void OnTriggerEnter2D(){
     
	}
}
