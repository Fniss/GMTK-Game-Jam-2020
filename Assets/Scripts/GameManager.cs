using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

public GameObject gameOverPanel;

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
    }

}
