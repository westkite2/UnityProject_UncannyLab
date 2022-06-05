using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player1Attack : MonoBehaviour
{
    public GameObject bullet;
    public GameObject fire;
    public GameObject fog;
    public GameObject Player;
    public GameObject drawer;
    public GameObject openeddrawer;
    public GameObject gunimage;


    public bool hasgun;
    public bool hasbullet;
    public bool haswater;
    public bool hasgunbullet;
    public bool haskey;

    private float Dist;
    private float Dist2;

    public Transform pos;
    


    void Update()
    {   
        if(hasbullet == true && hasgun == true)
        {   if(Input.GetKeyDown(KeyCode.Q))
            {
                Instantiate(bullet, pos.position, transform.rotation);
            }
        }

        if(hasgunbullet == true)
        {   if(Input.GetKeyDown(KeyCode.Q))
            {
                Instantiate(bullet, pos.position, transform.rotation);
            }
        }

        Dist = Vector3.Distance(Player.transform.position, fire.transform.position);
        Dist2 = Vector3.Distance(Player.transform.position, drawer.transform.position);
        ExtinguishFire();


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

        if(other.gameObject.tag == "enemy")
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
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
                    haskey = false;
                    openeddrawer.SetActive(true);
                    gunimage.SetActive(true);
                }
            }
        }
    }

}
