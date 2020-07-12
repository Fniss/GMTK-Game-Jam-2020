using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScreen : MonoBehaviour
{
    public int screenIndex;
   void Update()
   {
       if (Input.anyKeyDown)
       {
           OnButtonPress();
       }
   }
   public void OnButtonPress()
   {
        SceneManager.LoadScene(screenIndex);
   }
}
