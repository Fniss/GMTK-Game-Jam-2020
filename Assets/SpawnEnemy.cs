using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject car,truck;
    public float chanceToSpawn;
    public float rateOfTrucks;
    public bool sendUp;
    public float cooldown, timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (Random.value < chanceToSpawn && timer <=0)
        {
            GameObject spawn = Random.value < rateOfTrucks? Instantiate(truck, transform.position, Quaternion.identity):Instantiate(car,transform.position,Quaternion.identity);
            spawn.GetComponent<EnemyCar>().goingUp = sendUp;
            timer = cooldown;
            if (!sendUp)
            {
                spawn.transform.Rotate(-Vector3.forward, 180);
            }
        }
    }
}
