using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class Pause : MonoBehaviour{
    public Button music, restart, quit, play, pause; 
    public SpriteRenderer m, r, q, pl, pa;
    public Sprite mu, re, qu, pla, pau;
    public bool active = false;
    private Sprite temp, temp2, temp3, temp4, temp5;

    void Start(){
        m = GetComponent<SpriteRenderer>();
        r = GetComponent<SpriteRenderer>();
        q = GetComponent<SpriteRenderer>();
        pl = GetComponent<SpriteRenderer>();
        pa = GetComponent<SpriteRenderer>();

        mu = Resources.Load<Sprite>("Layer_8_copy_4");
        re = Resources.Load<Sprite>("Layer_10_copy");
        qu = Resources.Load<Sprite>("Layer_11_copy");
        pla = Resources.Load<Sprite>("Layer_12_copy");
        pau = Resources.Load<Sprite>("Layer_12_copy");

        
	}
        void Update(){
        OnEnable();  
		}
 
    	void OnEnable()
    	{
    		music.onClick.AddListener(ChangeSound);
            restart.onClick.AddListener(ChangeRestart);
            quit.onClick.AddListener(ChangeQuit);
            play.onClick.AddListener(ChangePlay);
            pause.onClick.AddListener(ChangePause);
    	}

    	void ChangeSound()
    	{
            temp = m.sprite;
            if(!active){
                m.sprite = mu;
                active = true;
			}
            else{
            m.sprite = temp;
            active = false;
			}
          
    	}
        void ChangeRestart()
    	{
            r.sprite = re;
    	}
        void ChangeQuit()
    	{
            q.sprite = qu;
    	}
        void ChangePlay()
    	{
            pl.sprite = pla;
    	}
        void ChangePause()
    	{
            pa.sprite = pau;
    	}
}