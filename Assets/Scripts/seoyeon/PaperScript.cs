using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject paper;
    
    private void Start()
    {
        paper.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        paper.SetActive(true);
        audioSource.Play();

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        paper.SetActive(false);
    }
}
