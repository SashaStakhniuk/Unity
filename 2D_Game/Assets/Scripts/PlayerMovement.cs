using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    PlayerControls playerControls;
    public Rigidbody2D playerRB;
    public float speed = 200;
    public float JumpForce = 10;
    public int JumpCount = 1;
    private int AvailableJumpAmount;


    public Animator animator;
    bool isRight = true;
    float direction = 0;
    public bool isGrounded = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGroundedCheck = true;
    private void Awake()
    {
        playerControls = new PlayerControls();
        playerControls.Enable();
        playerControls.Land.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();

        };
        playerControls.Land.Jump.performed += ctx => Jump();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,0.1f, groundLayer);
        playerRB.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, playerRB.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(direction));
        if (isGroundedCheck != isGrounded)
        {
            animator.SetBool("isGrounded", isGrounded);
            isGroundedCheck = isGrounded;
        }


        if (isRight && direction < 0 || !isRight && direction > 0)
        {
            Flip();
        }
    }

    private void Flip()
    {
        isRight = !isRight;
        transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
        //transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, 1);

    }
    private void Jump()
    {
        Debug.Log("Jump");
        if (isGrounded)
        {
            AvailableJumpAmount = JumpCount;
            AvailableJumpAmount--;
            Debug.Log("On the ground");
            playerRB.velocity = new Vector2(playerRB.velocity.x, JumpForce);
        }
        else
        {
            if (AvailableJumpAmount > 0)
            {
                AvailableJumpAmount--;
                playerRB.velocity = new Vector2(playerRB.velocity.x, JumpForce);
                Debug.Log("In the air");
                Debug.Log("jumpAmountLeft->" + AvailableJumpAmount);

            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Enemy");
            Destroy(gameObject);
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        if (other.tag == "SpeedEncreaseItem")
        {
            Debug.Log("SpeedEncreaseItem");
            speed = 500;
            Destroy(other.gameObject);

            //Scene scene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(scene.name);
        }
        if (other.tag == "JumpEncreaseItem")
        {
            Debug.Log("JumpEncreaseItem");
            JumpCount = 2;
            Destroy(other.gameObject);

            //Scene scene = SceneManager.GetActiveScene();
            //SceneManager.LoadScene(scene.name);
        }
    }
}
