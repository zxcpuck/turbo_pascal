using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;
    public GameObject pauseGameMenu;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // встановлюєм кнопку на яку буде забінджена пауза
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }// 1) коли натиснута кнопка продовжити вікно pauseGameMenu = false 
     // 2) Time.timeScale = 1f; відновлюєм рух персонажа
     // 3) PauseGame = false; пауза віджимається , ігра продовжується

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }// 1) коли натиснута кнопка паузи вікно pauseGameMenu = true
     // 2) Time.timeScale = 0f; призупиняється рух персонажа
     // 3) PauseGame = true; ігра стає на паузу

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }// вивід кнопки menu та її функціонал (перехід в головне меню)
}
