using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomVFX : MonoBehaviour
{

    void Start()
    {
        Invoke("DestroyboomVFX", 0.5f);
    }

    void DestroyboomVFX()
    {
        Destroy(gameObject);
    }
}
