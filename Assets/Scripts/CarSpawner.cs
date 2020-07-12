using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
public float spawnRate;

public GameObject car;


    void Start()
    {
    Invoke("SpawnCar", spawnRate);
    }
    void SpawnCar()
    {
    Instantiate(car, transform.position, transform.rotation);
    }


}
