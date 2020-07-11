using UnityEngine;

public class PauseMenu : MonoBehaviour
{
[Header("Keybinds")]
//  This is the keybind that pauses the game.
public KeyCode pauseKey;
[HideInInspector]
public bool isPaused = false;
[Header("UI Panel")]
public GameObject pausePanel;



    void Update()
    {
    if (Input.GetKeyDown(pauseKey))
    {
    if (isPaused)
    Resume();
    else
    Pause();
    }
    }
    public void Pause()
    {
    pausePanel.SetActive(true);
    isPaused = true;
    Time.timeScale = 0f;
    }
    public void Resume()
    {
    pausePanel.SetActive(false);
    isPaused = false;
    Time.timeScale = 1f;
    }
    public void Quit()
    {
    Application.Quit(1);
    }
    



}
