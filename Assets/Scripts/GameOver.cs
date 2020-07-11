using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
public TextMeshProUGUI scoreText;

    public void OnEnable()
    {
    scoreText.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }

    public void Restart()
    {
    SceneManager.LoadScene(0);
    }
    public void Quit()
    {
    Application.Quit(1);
    }



}
