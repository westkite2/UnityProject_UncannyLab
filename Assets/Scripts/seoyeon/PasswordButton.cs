using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordButton : MonoBehaviour
{
    public Sprite[] sprite;
    private Image image;
    private int buttonNum;
    private bool isPressed;
    GameManager gameManager;

    private int GetButtonNum(string name)
    {
        switch (name)
        {
            case "Button (1)":
                return 1;
            case "Button (2)":
                return 2;
            case "Button (3)":
                return 3;
            case "Button (4)":
                return 4;
            case "Button (5)":
                return 5;
            case "Button (6)":
                return 6;
            case "Button (7)":
                return 7;
            case "Button (8)":
                return 8;
            case "Button (9)":
                return 9;
        }
        return 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        gameManager = GameManager.Instance;
        image.sprite = sprite[0];
        isPressed = false;
        buttonNum = GetButtonNum(gameObject.name);
    }
    public void OnClickButton()
    {
        if (!isPressed) // not pressed
        {
            isPressed = true;
            image.sprite = sprite[1];
            gameManager.PasswordButtonStatus(buttonNum, isPressed);
        }
        else // pressed
        {
            isPressed = false;
            image.sprite = sprite[0];
            gameManager.PasswordButtonStatus(buttonNum, isPressed);
        }
    }
}
