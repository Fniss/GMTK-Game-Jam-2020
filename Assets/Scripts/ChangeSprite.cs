using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
   private SpriteRenderer rend;
   private Sprite first, second, third, fourth;
   private PlayerHealth playerHealth;
   
   private void Start(){
   	   rend = GetComponent<SpriteRenderer>();
       first = Resources.Load<Sprite>("redcar.1");
       second = Resources.Load<Sprite>("redcar.2");
       third = Resources.Load<Sprite>("redcar.3");
       fourth = Resources.Load<Sprite>("redcar.4");
       rend.sprite = first;
       playerHealth = GetComponent<PlayerHealth>();
   }

   private void Update(){
        if(playerHealth.currentHealth == 10){
            rend.sprite = first;  
		}
        else if(playerHealth.currentHealth < 10 && playerHealth.currentHealth >= 7.5){
            rend.sprite = second;  
		}
        else if(playerHealth.currentHealth < 7.5 && playerHealth.currentHealth >= 5){
            rend.sprite = third;  
		}
        else{
            rend.sprite = fourth;
		}   
   }
}
