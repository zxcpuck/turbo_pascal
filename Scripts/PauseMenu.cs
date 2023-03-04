using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;
    public GameObject pauseGameMenu;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // ����������� ������ �� ��� ���� ��������� �����
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
    }// 1) ���� ��������� ������ ���������� ���� pauseGameMenu = false 
     // 2) Time.timeScale = 1f; ��������� ��� ���������
     // 3) PauseGame = false; ����� ���������� , ���� ������������

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }// 1) ���� ��������� ������ ����� ���� pauseGameMenu = true
     // 2) Time.timeScale = 0f; �������������� ��� ���������
     // 3) PauseGame = true; ���� ��� �� �����

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }// ���� ������ menu �� �� ���������� (������� � ������� ����)
}
