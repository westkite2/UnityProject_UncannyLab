using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet3 : MonoBehaviour
{
    public float speed;
    

    void Start()
    {
        Invoke("DestroyBullet", 2);

    }

    void Update()
    {    
        transform.Translate(transform.up*speed*Time.deltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
