using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   
    [Header("Health")]
    public int currentHealth = 3;
    public int maxHealth = 3;
    [Header("References")]
    public GameManager gM;

    void Update()
    {
    if (currentHealth == 0)
    Die();
    }
     
    void OnTriggerEnter2D(Collider2D other)
    {
    if (other.CompareTag("StillObstacles"))
    {
    currentHealth -= 1;
    GetComponent<Animator>().SetFloat ("PlayerHealth", currentHealth);
    FindObjectOfType<AudioManager>().Play("Crash");
    Debug.Log("We hit an obstacle!");
    }
    }
    void Die()
    {
    gM.GameOver();
    }


}
