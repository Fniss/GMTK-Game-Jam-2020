using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrafficCone : BaseObstacle//, IBeginDragHandler,IEndDragHandler, IDragHandler, IPointerEnterHandler
{
public Camera cam;
bool isDragging = false;

public float timer, lifetime;

    void Awake()
    {
    // cam = FindObjectOfType	<Camera>();
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > lifetime)
        { 
            if (!hasDoneDamage)
                FindObjectOfType<PlayerHealth>().currentPoints+= pointsValue;

                Destroy(gameObject);
        }

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

    // public void OnPointerDown(PointerEventData eventData)
    // {
    // isDragging = true;
    // }

    // public void OnPointerUp(PointerEventData eventData)
    // {
    // isDragging = false;
    // }

    // public void OnDrag(PointerEventData eventData)
    // {
    //     transform.position += (Vector3)eventData.delta;
    // }

    // public void OnBeginDrag(PointerEventData eventData)
    // {
    // }

    // public void OnEndDrag(PointerEventData eventData){
    // }

    // public void OnPointerEnter(PointerEventData eventData)
    // {
    //     Debug.Log("rest" +  name);
    // }
}
