using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject button;
    ButtonController buttonController;

    Animator animator;
    Collider2D collider2d;
    bool isOpened = false;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        buttonController = button.GetComponent<ButtonController>();
        collider2d = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {        
        
        if(buttonController.status == true) //open
        {
            if (isOpened == false)
            {
                animator.SetTrigger("Open");
                isOpened = true;
                collider2d.enabled = false;
                audioSource.Play();

            }
        }
        else //closed
        {
            if (isOpened)
            {
                animator.SetTrigger("Close");   
                isOpened = false;
                collider2d.enabled = true;
                audioSource.Play();

            }
        }
    }
}
