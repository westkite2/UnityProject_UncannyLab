using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject selectWindow;
    public GameObject shades;
    public GameObject mapCamera;
    bool isCamOn;

    private void Start()
    {
        pausePanel.SetActive(false);
        mapCamera.SetActive(false);
        isCamOn = false;
    }
    public void OnClickPauseButton()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }
    public void OnClickKeepPlayingButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OnClickRetryButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //selectWindow.SetActive(true);
    }
    public void OnClickGoStartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameStart");
    }

    public void Camera()
    {
        if (!isCamOn)
        {
            mapCamera.SetActive(true);
            shades.SetActive(false);
            isCamOn = true;
        }
        else
        {
            mapCamera.SetActive(false);
            shades.SetActive(true);
            isCamOn = false;
        }

    }
}
