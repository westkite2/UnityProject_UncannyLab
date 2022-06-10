using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class potion2 : MonoBehaviour
{
    public void berserker2()
    {
        Gauge2p call2 = GameObject.Find("Slider2p").GetComponent<Gauge2p>();   
        call2.slTimer2.value +=20;
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "player")
        {
            berserker2();
            Destroy(gameObject);
            Debug.Log("안정제 획득");
            
        }
    }
}
