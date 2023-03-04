using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int sceneNumber;

    public void Transition()
    {
        SceneManager.LoadScene(sceneNumber);
    }// кнопка в головному меня на перехід в іншу сцену
}
