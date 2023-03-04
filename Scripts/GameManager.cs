using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loseWindow;
    public static GameManager instance;

    private void Start()
    {
        instance = this;// беремо фокус на себе
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;// рестарт ігри та відновлення руху персонажа
    }

    public void Lose()
    {
        loseWindow.SetActive(true);
        Time.timeScale = 0;// вивід екрану смерті та призупинка ігри
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;// голловне меню та дії там
    }
}
