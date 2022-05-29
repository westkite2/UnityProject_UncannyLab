using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    Slider slTimer;
    float fSliderBarTime;

    void Start()
    {
        slTimer = GetComponent<Slider>();
        slTimer.value = 100;    
    }

    void Update()
    {
        if (slTimer.value>0.0f)
        {
            slTimer.value -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time is Zero.");
        }
    }


}
