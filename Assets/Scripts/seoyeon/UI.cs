using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject selectWindow;
    public GameObject shades;
    public GameObject mapCamera;

    public GameObject player1;
    player1Attack player1attack;
    public GameObject player2;
    player2Attack player2attack;

    public Toggle player1Guntoggle;
    public Toggle player2Guntoggle;
    public Toggle player1Bullettoggle;
    public Toggle player2Bullettoggle;
    public Toggle player1Watertoggle;
    public Toggle player2Watertoggle;
    public Toggle player1GunBullettoggle;
    public Toggle player2GunBullettoggle;
    public Toggle player1Keytoggle;
    public Toggle player2Keytoggle;

    bool isCamOn;
    bool isShadeOn;

    private void Start()
    {
        player1attack = player1.GetComponent<player1Attack>();
        player2attack = player2.GetComponent<player2Attack>();
        pausePanel.SetActive(false);
        mapCamera.SetActive(false);
        isCamOn = false;
        isShadeOn = true;
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

    public void Shade()
    {
        if (isShadeOn)
        {
            shades.SetActive(false);
            isShadeOn = false;
        }
        else
        {
            shades.SetActive(true);
            isShadeOn = true;
        }

    }

    public void Player1HasGun()
    {
        if (player1Guntoggle.isOn) player1attack.hasgun = true;
        else player1attack.hasgun = false;
    }
    public void Player2HasGun()
    {
        if (player2Guntoggle.isOn) player2attack.hasgun = true;
        else player2attack.hasgun = false;
    }
    public void Player1HasBullet()
    {
        if (player1Bullettoggle.isOn) player1attack.hasbullet = true;
        else player1attack.hasbullet = false;
    }
    public void Player2HasBullet()
    {
        if (player2Bullettoggle.isOn) player2attack.hasbullet = true;
        else player2attack.hasbullet = false;
    }
    public void Player1HasWater()
    {
        if (player1Watertoggle.isOn) player1attack.haswater = true;
        else player1attack.haswater = false;
    }
    public void Player2HasWater()
    {
        if (player2Watertoggle.isOn) player2attack.haswater = true;
        else player2attack.haswater = false;
    }
    public void Player1HasGunBullet()
    {
        if (player1GunBullettoggle.isOn) player1attack.hasgunbullet = true;
        else player1attack.hasgunbullet = false;
    }
    public void Player2HasGunBullet()
    {
        if (player2GunBullettoggle.isOn) player2attack.hasgunbullet = true;
        else player2attack.hasgunbullet = false;
    }
    public void Player1HasKey()
    {
        if (player1Keytoggle.isOn) player1attack.haskey = true;
        else player1attack.haskey = false;
    }
    public void Player2HasKey()
    {
        if (player2Keytoggle.isOn) player2attack.haskey = true;
        else player2attack.haskey = false;
    }
}
