using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

public GameObject gameOverPanel;
public GameObject pauseMenu;

[HideInInspector]
public int health = 3;

    public void GameOver()
    {
    gameOverPanel.SetActive(true);
    }
    public void ReduceHealth()
    {
    health--;
    }
    public void Update()
    {
    if (health == 0)
    GameOver();
    if (Input.GetKeyDown(KeyCode.Escape))
    {   
        pauseMenu.SetActive (true);
        Time.timeScale = 0;
    }
    else if (Input.GetKeyDown(KeyCode.Q))
    {
        GameOver();
    }
    }

}
