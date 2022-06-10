using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.0f;

    private int playerNum;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    public Vector2 lookDirection;

    GameManager gameManager;
    
    void SetAnimator(int num)
    {        
        switch (num)
        {
            case 1:
                Debug.Log("1~");
                animator.runtimeAnimatorController = Resources.Load("Animation/Player1Controller") as RuntimeAnimatorController;
                break;
            case 2:
                Debug.Log("2~");
                animator.runtimeAnimatorController = Resources.Load("Animation/Player2Controller") as RuntimeAnimatorController;
                break;
            case 3:
                animator.runtimeAnimatorController = Resources.Load("Animation/Player3Controller") as RuntimeAnimatorController;
                break;
            case 4:
                animator.runtimeAnimatorController = Resources.Load("Animation/Player4Controller") as RuntimeAnimatorController;
                break;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        //Identify player view
        switch (gameObject.name)
        {
            case "Player1":
                playerNum = 1;
                lookDirection = new Vector2(1, 0);
                break;
            case "Player2":
                playerNum = 2;
                lookDirection = new Vector2(-1, 0);
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(gameManager.step == 3)
        {
            if(playerNum == 1) SetAnimator(gameManager.player1character);
            else SetAnimator(gameManager.player2character);
        }

        //Get keyboard Input
        if(playerNum == 1)
        {
            horizontal = Input.GetAxis("Horizontal2");
            vertical = Input.GetAxis("Vertical2");
        }
        else if(playerNum == 2)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }

        // Change direction of player animation
        Vector2 move = new Vector2(horizontal, vertical);
        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        animator.SetFloat("Move X", lookDirection.x);
        animator.SetFloat("Move Y", lookDirection.y);

    }

    private void FixedUpdate()
    {
        // Move Player
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
}
