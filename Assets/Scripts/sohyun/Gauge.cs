using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gauge : MonoBehaviour
{
    public Slider slTimer;
    float fSliderBarTime;

    public float speed = 0.5f;

    void Start()
    {
        slTimer = GetComponent<Slider>();
        slTimer.value = 60;    
    }

    void Update()
    {
        berserkergauge();
    }

    public void berserkergauge()
    {
        if (slTimer.value>0.0f)
        {
            slTimer.value -= Time.deltaTime * speed;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
