using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour
{
    public float speed;
    

    void Start()
    {
        Invoke("DestroyBullet", 2);

    }

    void Update()
    {    
        transform.Translate(transform.right*-1*speed*Time.deltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
