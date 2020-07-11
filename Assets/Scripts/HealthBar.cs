using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image fillImage; //Add an image to UI
    private Slider slider; //Add a slider to UI

    // Start is called before the first frame update
    void Start()
    {
    slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update() 
    {
        //  Set the slider value to the player's health
    slider.value = playerHealth.currentHealth;
    slider.maxValue = playerHealth.maxHealth;
    }
}
