using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge2p : MonoBehaviour
{
    Slider slTimer2;
    float fSliderBarTime2;

    void Start()
    {
        slTimer2 = GetComponent<Slider>();
        slTimer2.value = 100;    
    }

    void Update()
    {
        if (slTimer2.value>0.0f)
        {
            slTimer2.value -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time is Zero.2");
        }
    }

}
