using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge2p : MonoBehaviour
{
    public Slider slTimer2;
    float fSliderBarTime2;

    void Start()
    {
        slTimer2 = GetComponent<Slider>();
        slTimer2.value = 60;    
    }

    void Update()
    {
        berserkergauge2();
    }

    public void berserkergauge2()
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
