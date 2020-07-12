using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
    
public class Pause : MonoBehaviour{
    public Button button; 
    public SpriteRenderer rend;
    public GameObject menu;
    public Sprite active, inactive;
    public bool on = false;
    public void Unpause(){
        Time.timeScale = 1;
        menu.SetActive(false);
    }
    public void Restart(){
        
        SceneManager.LoadScene(0);
    }
    public void Quit(){
        
    Application.Quit(1);
    }
    public void Mute()
    {
        FindObjectOfType<AudioSource>().mute = !FindObjectOfType<AudioSource>().mute;
    }
    void Start(){
        // rend = GetComponent<SpriteRenderer>();

        // active = Resources.Load<Sprite>("Layer_8_copy_3");
        // inactive = Resources.Load<Sprite>("Layer_8_copy_4");
	}
        // void Update(){
        // OnEnable();  
		// }
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