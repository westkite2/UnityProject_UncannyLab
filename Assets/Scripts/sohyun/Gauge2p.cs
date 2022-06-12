using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gauge2p : MonoBehaviour
{
    public Slider slTimer2;
    float fSliderBarTime2;

    public float speed = 0.5f;

    void Start()
    {
        slTimer2 = GetComponent<Slider>();
        slTimer2.value = 300;    
    }

    void Update()
    {
        berserkergauge2();
    }

    public void berserkergauge2()
    {
        if (slTimer2.value>0.0f)
        {
            slTimer2.value -= Time.deltaTime * speed;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
