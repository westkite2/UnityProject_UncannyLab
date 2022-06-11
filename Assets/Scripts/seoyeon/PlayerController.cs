using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.0f;

    private int playerNum;
    private int playerCharacter;
    private bool issettingDone = false;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    public Vector2 lookDirection;

    GameManager gameManager;

    public GameObject shader1;
    public GameObject shader2;

    Image playerShade;
    public Sprite[] sprite;
    public GameObject targetIndicator;
    public GameObject gauge;

    void SetAnimator(int num)
    {        
        switch (num)
        {
            case 1:
                animator.runtimeAnimatorController = Resources.Load("Animation/Player1Controller") as RuntimeAnimatorController;
                break;
            case 2:
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

    void SetGaugeSpeed(int num)
    {
        if (num == 1)
        {
            if (playerNum == 1) gauge.GetComponent<Gauge>().speed = 0.5f;
            else gauge.GetComponent<Gauge2p>().speed = 0.5f;
        }
    }
     void SetIndicator(int num)
    {
        if (num == 2) targetIndicator.SetActive(true);
        else targetIndicator.SetActive(false);
    }

    void SetShader(int num)
    {
        if(num == 3)
        {
            if (playerNum == 1) playerShade = shader1.GetComponent<Image>();
            else playerShade = shader2.GetComponent<Image>();

            playerShade.sprite = sprite[0];
        }
    }
    void SetSpeed(int num)
    {
        if (num == 4) speed = 3.5f;
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
        if(gameManager.step == 3 & !issettingDone) // After character selection
        {
            // Identify player character number
            if (playerNum == 1) playerCharacter = gameManager.player1character;
            else playerCharacter = gameManager.player2character;

            // Apply character private settings
            SetAnimator(playerCharacter);
            SetGaugeSpeed(playerCharacter);
            SetIndicator(playerCharacter);
            SetShader(playerCharacter);
            SetSpeed(playerCharacter);
            issettingDone = true;
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
