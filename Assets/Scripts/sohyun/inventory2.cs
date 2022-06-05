using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory2 : MonoBehaviour
{
    public Sprite[] imagenum;
    Image inventoryimage;
    private player2Attack player2Attack;

    void Start()
    {
        inventoryimage = GetComponent<Image>();
        player2Attack = GameObject.Find("Player2").GetComponent<player2Attack>();
    }

    void Update()
    {
        inventoryimagechange();
    }

    void inventoryimagechange()
    {
        if (player2Attack.haswater == true)
        {
            inventoryimage.sprite = imagenum[1];
        }

        if(player2Attack.haskey == true)
        {
            inventoryimage.sprite = imagenum[2];
            Debug.Log("키");
        }
        
        if(player2Attack.hasgun == true)
        {
            inventoryimage.sprite = imagenum[3];
        }
        
        if(player2Attack.hasbullet == true)
        {
            inventoryimage.sprite = imagenum[4];
        }

        if(player2Attack.hasgunbullet == true)
        {
            inventoryimage.sprite = imagenum[5];
        }

        if(player2Attack.haswater == false && player2Attack.haskey == false &&
        player2Attack.hasgun == false && player2Attack.hasbullet == false 
        && player2Attack.hasgunbullet == false)
        {
            inventoryimage.sprite = imagenum[0];
        }
    }
}
