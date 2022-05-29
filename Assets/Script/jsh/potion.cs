using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class potion : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) 
    {

        if(other.gameObject.tag == "player")
        {
            Debug.Log("안정제 획득");
        }
    }


}
