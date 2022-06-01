using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class potion : MonoBehaviour
{
    public void berserker()
    {
        Gauge call = GameObject.Find("Slider1p").GetComponent<Gauge>();   
        call.slTimer.value +=20;
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "player")
        {
            berserker();
            Destroy(gameObject);
            Debug.Log("안정제 획득");
            
        }
    }

}
