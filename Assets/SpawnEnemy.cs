using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject car,truck;
    public float chanceToSpawn;
    public float rateOfTrucks;
    public bool sendUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.value < chanceToSpawn)
        {
            GameObject spawn = Random.value < rateOfTrucks? Instantiate(truck, transform.position, Quaternion.identity):Instantiate(car,transform.position,Quaternion.identity);
            spawn.GetComponent<EnemyCar>().goingUp = sendUp;

            if (!sendUp)
            {
                spawn.transform.Rotate(-Vector3.forward, 180);
            }
        }
    }
}
