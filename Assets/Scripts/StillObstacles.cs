using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StillObstacles : MonoBehaviour 
{
    private BoxCollider2D coll; 
    public int damage = 2;

    // Start is called before the first frame update
    void Start()
    {
    coll = GetComponent<BoxCollider2D>();
    }
}
