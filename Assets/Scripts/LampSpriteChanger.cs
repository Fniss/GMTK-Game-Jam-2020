using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSpriteChanger : MonoBehaviour
{
   private Sprite brokenL, brokenR;
   private BoxCollider2D coll;
   private SpriteRenderer rend;

   private void Start(){
   	   rend = GetComponent<SpriteRenderer>();
       brokenL = Resources.Load<Sprite>("broken_lamp_L");
       brokenR = Resources.Load<Sprite>("broken_lamp_R");
       coll = GetComponent<BoxCollider2D>();
   }

   void OnCollisionEnter2D(Collision2D coll){
    if(gameObject.tag == "Left"){
        rend.sprite = brokenL;
    }
    if(gameObject.tag == "Right"){   
        rend.sprite = brokenR;
	}
   }
}
