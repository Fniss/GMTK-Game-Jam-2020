using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts; //number of car lives

    public Image[] hearts; //Array of lives
    public Sprite fullHeart; //indicates a life
    public Sprite emptyHeart; //indicates a life is lost

    public PlayerHealth playerHealth;

    void Start(){
        playerHealth = GetComponent<PlayerHealth>();
	}

    void Update(){ //Adjusts the amount of lives
        health = playerHealth.currentHealth;
        for(int i = 0; i < hearts.Length; i++){ 
            if(health > numOfHearts){
                health = numOfHearts;     
			}

            if(i < health){
                hearts[i].sprite = fullHeart;     
			}   
            else{
                hearts[i].sprite = emptyHeart;    
			}

            if(i < numOfHearts){
                hearts[i].enabled = true;         
			}  
            else{
                hearts[i].enabled = false;     
			}
		}   
	}

 
}
