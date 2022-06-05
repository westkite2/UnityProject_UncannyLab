using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Invoke("DestroyBullet", 2);
    }

    void Update()
    {

            transform.Translate(transform.right*speed*Time.deltaTime);

    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
