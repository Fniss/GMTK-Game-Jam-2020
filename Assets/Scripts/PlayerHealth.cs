using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{   
    [Header("Health")]
    public int currentHealth = 3;
    public int currentPoints = 0;
    public int maxHealth = 3;
    [Header("References")]
    public TextMeshProUGUI scoreText;
    public GameManager gM;
    void Start()
    {
        currentHealth = maxHealth;
        currentPoints = 0;
    }
    void Update()
    {
    if (currentHealth == 0)
    Die();
    scoreText.text = currentPoints.ToString();
    }
     
    void OnTriggerEnter2D(Collider2D other)
    {
    if (other.CompareTag("StillObstacles"))
    {
        currentHealth -= 1;
        GetComponent<Animator>().SetFloat ("PlayerHealth", currentHealth);
        FindObjectOfType<AudioManager>().Play("Crash");
        Debug.Log("We hit an obstacle!");
        //currentPoints -= other.GetComponent<BaseObstacle>().damageAmount;
        other.GetComponent<BaseObstacle>().hasDoneDamage = true;
    }
    }
    void Die()
    {
    gM.GameOver();
    }


}
