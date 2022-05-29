using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttak : MonoBehaviour
{
    public GameObject bullet;
    public Transform pos;
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
        {   if(Input.GetKeyDown(KeyCode.L))
            {
                Instantiate(bullet,pos.position, transform.rotation);
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
        
    }

}
