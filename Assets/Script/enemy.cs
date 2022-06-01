using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    int health = 5;


    void Start()
    {
        Debug.Log("적 health 값 : " + health);
    }

    void TakeDamage(int value)
    {   
        health -= value;
        if(health <= 0) 
        {
            Destroy(this.gameObject);
        } 
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
            {
                TakeDamage(1);
                Debug.Log(health);
                other.gameObject.SetActive(false);
            }
        
        if(other.gameObject.tag == "player")
            {
                Debug.Log("적에게 잡혀서 게임오버");
            }
    }

}
