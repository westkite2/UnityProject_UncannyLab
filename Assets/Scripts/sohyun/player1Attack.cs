using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player1Attack : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip audiowater;
    public AudioClip audiodrawer;
    public AudioClip audiogun;

    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;
    public GameObject fire;
    public GameObject fog;
    public GameObject Player;
    public GameObject drawer;
    public GameObject openeddrawer;
    public GameObject gunimage;
    public GameObject belt;
    public GameObject beltgun;
    public GameObject water;
    public GameObject beltbullet;
    public GameObject gunbullet;

    public bool hasgun;
    public bool hasbullet;
    public bool haswater;
    public bool hasgunbullet;
    public bool haskey;

    private float Dist;
    private float Dist2;
    private float Dist3;

    public Transform pos;
    public Transform posbelt;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();    
    }


    void Update()
    {   
        if(hasbullet == true && hasgun == true)
        {
            hasgunbullet = true;
            hasgun = false;
            hasbullet = false;
        }

        if(hasgunbullet == true)
        {   if(Dist3 > 0.7){
            if(Input.GetKeyDown(KeyCode.Q))
            {    if(GameObject.Find("Player1").GetComponent<PlayerController>().lookDirection.x > 0)
                {
                    PlaySound("GUN");
                    Instantiate(bullet, pos.position, transform.rotation);
                }

                else if(GameObject.Find("Player1").GetComponent<PlayerController>().lookDirection.x < 0)
                {
                    PlaySound("GUN");
                    Instantiate(bullet2, pos.position, transform.rotation);
                }

                else if(GameObject.Find("Player1").GetComponent<PlayerController>().lookDirection.y > 0)
                {
                    PlaySound("GUN");
                    Instantiate(bullet3, pos.position, transform.rotation);
                }

                else if(GameObject.Find("Player1").GetComponent<PlayerController>().lookDirection.y < 0)
                {
                    PlaySound("GUN");
                    Instantiate(bullet4, pos.position, transform.rotation);
                }
            }
        }
        }

        Dist = Vector3.Distance(Player.transform.position, fire.transform.position);
        Dist2 = Vector3.Distance(Player.transform.position, drawer.transform.position);
        Dist3 = Vector3.Distance(Player.transform.position, belt.transform.position);
        ExtinguishFire();
        Conveyorbelt();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "gun")
        {
            hasgun = true;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "bulletimage")
        {
            hasbullet = true;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "gunbullet")
        {
            hasgunbullet = true;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("GameOver");
        }

        if(other.gameObject.tag == "water")
        {
            haswater = true;
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "key")
        {
            haskey = true;
            Destroy(other.gameObject);
        }
    
        if(other.gameObject == fire)
        {
            SceneManager.LoadScene("GameOver");
        }

        
    }

    void ExtinguishFire()
    {
        if(Dist <= 1.8)
        {
            if(haswater == true)
            {
                if(Input.GetKeyDown(KeyCode.Q))
                {
                    PlaySound("WATER");
                    Destroy(fire);
                    Destroy(fog);
                    haswater = false;
                }
            }
        }

        if(Dist2<=0.7)
        {   
            if(haskey == true)
            {
                if(Input.GetKeyDown(KeyCode.Q))
                {   
                    PlaySound("DRAWER");
                    haskey = false;
                    openeddrawer.SetActive(true);
                    gunimage.SetActive(true);
                }
            }
        }
    }

    void Conveyorbelt()
    {
        if(Dist3<=0.7)
        {
            if(haswater == true)
            {
                if(Input.GetKeyDown(KeyCode.Q))
                {
                    Instantiate(water, posbelt.position, transform.rotation);
                    haswater = false;
                }
            }

            if(hasbullet == true)
            {
                if(Input.GetKeyDown(KeyCode.Q))
                {
                    Instantiate(beltbullet, posbelt.position, transform.rotation);
                    hasbullet = false;
                }
            }

            if(hasgun == true)
            {
                if(Input.GetKeyDown(KeyCode.Q))
                {
                    Instantiate(beltgun, posbelt.position, transform.rotation);
                    hasgun = false;
                }
            }

            if(hasgunbullet == true)
            {
                if(Input.GetKeyDown(KeyCode.Q))
                {
                    Instantiate(gunbullet, posbelt.position, transform.rotation);
                    hasgunbullet = false;
                }
            }
        }
    }

    void PlaySound(string action)
    {
        switch (action)
        {
            case "WATER":
                audioSource.clip = audiowater;
                break;

            case "DRAWER":
                audioSource.clip = audiodrawer;
                break;
            
            case "GUN" :
                audioSource.clip = audiogun;
                break;
        }
        //audioSource.Play();
    }

}
