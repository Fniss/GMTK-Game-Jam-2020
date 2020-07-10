using UnityEngine;

public class CameraFollow : MonoBehaviour
{
[SerializeField]
Transform target;
[Space(5)]
[Header("Boundaries")]
[SerializeField]
float minX;
[SerializeField]
float maxX;
[SerializeField]
public float minY;
[SerializeField]
float maxY;



    void Update()
    {
    transform.position = target.position;



    transform.position = new Vector3(
    Mathf.Clamp(transform.position.x, minX, maxX),
    Mathf.Clamp(transform.position.y, minY, maxY),
    -100
    );
    }









}