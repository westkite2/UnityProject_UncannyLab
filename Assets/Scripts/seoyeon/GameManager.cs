using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public GameObject player1Text;
    public GameObject player2Text;
    public GameObject startText;
    public Button startButton;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public GameObject CharacterSelectCanvas;
    public int player1character;
    public int player2character;
    public int step;

    public GameObject Shade;

    public static GameManager Instance; // A static reference to the GameManager instance

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject); // Keep the GameObject, this component is attached to, across different scenes
            Instance = this;
        }
        else if (Instance != this) // If there is already an instance and it's not `this` instance
        {
            Destroy(gameObject); // Destroy the GameObject, this component is attached to
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        Shade.SetActive(false);
        CharacterSelectCanvas.SetActive(true);
        player1Text.SetActive(true);
        player2Text.SetActive(false);
        startText.SetActive(false);
        startButton.interactable = false;
        step = 1;
    }
    private void Update()
    {
        if (step == 3)
        {
            startButton.interactable = true;
        }
    }
    public void OnclickStartButton()
    {
        Shade.SetActive(true);
        CharacterSelectCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OnSelectCharacter()
    {

        if (step == 1)
        {
            player1character = GetCharacterNumber();
            step = 2;
            player1Text.SetActive(false);
            player2Text.SetActive(true);
        }
        else if (step == 2)
        {
            player2character = GetCharacterNumber();
            step = 3;
            player2Text.SetActive(false);
            startText.SetActive(true);
        }
    }

    private int GetCharacterNumber()
    {
        switch (EventSystem.current.currentSelectedGameObject.name)
        {
            case "Button1":
                Button1.interactable = false;
                return 1;
            case "Button2":
                Button2.interactable = false;
                return 2;
            case "Button3":
                Button3.interactable = false;
                return 3;
            case "Button4":
                Button4.interactable = false;
                return 4;
        }
        return -1;
    }
}