using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] car,truck;
    public GameObject[] coneRows;
    public bool ConeSpawn;
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
            if (!ConeSpawn)
            {
                GameObject spawn = Random.value < rateOfTrucks? Instantiate(truck[Random.Range(0,truck.Length)], transform.position, Quaternion.identity):Instantiate(car[Random.Range(0,car.Length)],transform.position,Quaternion.identity);
                spawn.GetComponent<EnemyCar>().goingUp = sendUp;
                timer = cooldown;
                if (!sendUp)
                {
                    spawn.transform.Rotate(-Vector3.forward, 180);
                }
            }
            else 
            {
                
                GameObject spawn = Instantiate (coneRows[Random.Range(0,coneRows.Length)], transform.position, Quaternion.identity);
                foreach (var c in spawn.transform.GetComponentsInChildren<TrafficCone>()){
                    c.cam = Camera.main;
                }
                timer = cooldown;
            }
        }
    }
}
