using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrafficCone : MonoBehaviour, IBeginDragHandler,IEndDragHandler, IDragHandler
{
public Camera cam;
bool isDragging = false;

    void Awake()
    {
    // cam = FindObjectOfType	<Camera>();
    }
    void Update()
    {
    // Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
    // pos.z = 0f;
    // if (isDragging)
    // transform.position = pos;
    }
    // void OnMouseDown()
    // {
    // isDragging = true;
    // }
    // void OnMouseUp()
    // {
    // isDragging = false;
    // }

    // public void OnPointerDown(PointerEventData eventData)
    // {
    // isDragging = true;
    // }

    // public void OnPointerUp(PointerEventData eventData)
    // {
    // isDragging = false;
    // }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position += (Vector3)eventData.delta;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    public void OnEndDrag(PointerEventData eventData){
    }
}
