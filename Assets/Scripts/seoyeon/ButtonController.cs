using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public AudioSource audioSource;
    public Sprite[] spriteList;
    private SpriteRenderer spriteRenderer;
    public bool isBeltButton = false;

    public bool status { get { return isPressed; } }
    private bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteList[0];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!isBeltButton) audioSource.Play();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isPressed = true;
        spriteRenderer.sprite = spriteList[1];
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPressed = false;
        spriteRenderer.sprite = spriteList[0];
    }

    

}
