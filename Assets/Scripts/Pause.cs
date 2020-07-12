using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class Pause : MonoBehaviour{
    public Button button; 
    public SpriteRenderer rend;
    public Sprite active, inactive;
    public bool on = false;

    void Start(){
        rend = GetComponent<SpriteRenderer>();

        active = Resources.Load<Sprite>("Layer_8_copy_3");
        inactive = Resources.Load<Sprite>("Layer_8_copy_4");
	}
        void Update(){
        OnEnable();  
		}
    	void OnEnable()
    	{
    		button.onClick.AddListener(Change);
    	}

    	void Change()
    	{

            if(!on){
                rend.sprite = active;
                on = true;
			}
            else{
                rend.sprite = inactive;
                on = false;
			}
          
    	}
   
}