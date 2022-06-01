using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player2Attack : MonoBehaviour
{
    public GameObject bullet2;
    public GameObject fire;
    public GameObject fog;
    public GameObject Player;
    public GameObject drawer;
    public GameObject openeddrawer;
    public GameObject bulletimage;


    public bool hasgun;
    public bool hasbullet;
    public bool haswater;
    public bool hasgunbullet;
    public bool haskey;

    private float Dist;
    private float Dist2;

    private Transform pos2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(hasbullet == true && hasgun == true)
        {   if(Input.GetKeyDown(KeyCode.L))
            {
                Instantiate(bullet2, pos2.position, transform.rotation);
            }
        }

        if(hasgunbullet == true)
        {   if(Input.GetKeyDown(KeyCode.Q))
            {
                Instantiate(bullet2,pos2.position, transform.rotation);
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

    }
    
    void ExtinguishFire()
    {
        if(Dist <= 1.7)
        {
            if(Input.GetKeyDown(KeyCode.L))
            {
                Destroy(fire);
                Destroy(fog);
                haswater = false;
            }
        }
        if(Dist2<=0.6)
        {
            if(Input.GetKeyDown(KeyCode.L))
            {
                haskey = false;
                openeddrawer.SetActive(true);
                bulletimage.SetActive(true);

            }
        }
    }

}
