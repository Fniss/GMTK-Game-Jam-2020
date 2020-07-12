using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainBridge : MonoBehaviour
{
bool isLowered = true;


    void OnMouseDown()
    {
    if (isLowered)
    {
    isLowered = false;
    gameObject.tag = null;
    }
    else
    {
    isLowered = true;
    gameObject.tag = "StillObstacle";
    }
    }
    



}
