using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public Sprite[] imagenum;
    Image inventoryimage;
    private player1Attack player1Attack;

    void Start()
    {
        inventoryimage = GetComponent<Image>();
        player1Attack = GameObject.Find("Player1").GetComponent<player1Attack>();
    }

    void Update()
    {
        inventoryimagechange();
    }

    void inventoryimagechange()
    {
        if (player1Attack.haswater == true)
        {
            inventoryimage.sprite = imagenum[1];
        }

        if(player1Attack.haskey == true)
        {
            inventoryimage.sprite = imagenum[2];
        }
        
        if(player1Attack.hasgun == true)
        {
            inventoryimage.sprite = imagenum[3];
        }
        
        if(player1Attack.hasbullet == true)
        {
            inventoryimage.sprite = imagenum[4];
        }

        if(player1Attack.hasgunbullet == true)
        {
            inventoryimage.sprite = imagenum[5];
        }

        if(player1Attack.haswater == false && player1Attack.haskey == false &&
        player1Attack.hasgun == false && player1Attack.hasbullet == false 
        && player1Attack.hasgunbullet == false)
        {
            inventoryimage.sprite = imagenum[0];
        }
    }
}
