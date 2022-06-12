using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    static public bool player1Exit;
    static public bool player2Exit;

    private void Start()
    {
        player1Exit = false;
        player2Exit = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player1")
        {
            player1Exit = true;
        }
        if(collision.gameObject.name == "Player2")
        {
            player2Exit = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player1")
        {
            player1Exit = false;
        }
        if(collision.gameObject.name == "Player2")
        {
            player2Exit = false;
        }

    }
}
