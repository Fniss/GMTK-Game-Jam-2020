using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCone : MonoBehaviour
{
Camera cam;
bool isDragging = false;

    void Start()
    {
    cam = Camera.main;
    }
    void Update()
    {
    Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
    pos.z = 0f;
    if (isDragging)
    transform.position = pos;
    }
    void OnMouseDown()
    {
    isDragging = true;
    }
    void OnMouseUp()
    {
    isDragging = false;
    }




}
