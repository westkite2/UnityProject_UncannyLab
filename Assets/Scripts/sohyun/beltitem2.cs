using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beltitem2 : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroyitem", 4);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right*-1*speed*Time.deltaTime);
    }

    void Destroyitem()
    {
        Destroy(gameObject);
    }
}
