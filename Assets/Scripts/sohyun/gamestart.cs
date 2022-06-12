using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestart : MonoBehaviour
{
    public void Gamestart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GameQuit()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
