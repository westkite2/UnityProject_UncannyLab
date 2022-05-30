using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1Attack : MonoBehaviour
{
    public GameObject bullet2;
    public Transform pos2;
    public bool hasgun;
    public bool hasbullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(hasbullet == true && hasgun == true)
        {   if(Input.GetKeyDown(KeyCode.Q))
            {
                Instantiate(bullet2,pos2.position, transform.rotation);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "gun")
        {
            hasgun = true;
        }

        if(other.gameObject.tag == "bulletimage")
        {
            hasbullet = true;
        }

        if(other.gameObject.tag == "enemy")
        {
            Time.timeScale = 0f;
            Destroy(gameObject);
        }

        
    }
}
