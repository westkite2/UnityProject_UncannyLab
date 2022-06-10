using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordButton : MonoBehaviour
{
    public Sprite[] sprite;
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = sprite[0];
    }

    public void OnClickButton()
    {
        image.sprite = sprite[1];
    }
}
