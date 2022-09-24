using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    private float moveSpeedStore; 
    public float jumpForce;

    public float speedMultiplier;
    public float speedIncreaseMilestoneStore;
    public float speedIncreaseMilestone;
    private float speedMilestoneCount;
    private float speedMilestoneCountStore;

    public GameManager theGameManager; 

    private Rigidbody2D myRigidbody;

    public bool grounded;
    public LayerMask WhatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    private Collider2D myCollider;

    private Animator myAnimator;

    public float jumpTime;
    private float jumpTimeCounter;

    public AudioSource JumpSound;
    

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();

        jumpTimeCounter = jumpTime;

        speedMilestoneCount = speedIncreaseMilestone;
        moveSpeedStore = moveSpeed;
        speedMilestoneCountStore = speedMilestoneCount;
        speedIncreaseMilestoneStore = speedIncreaseMilestone;
        
    }

    // Update is called once per frame
    void Update()
    {
        //grounded = Physics2D.IsTouchingLayers(myCollider, WhatIsGround);

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);


        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier; 
            moveSpeed = moveSpeed * speedMultiplier; 
        }

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {

            if (grounded)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                JumpSound.Play();
                
            }

        }

        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if (jumpTimeCounter > 0)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime ;

            }

            if(Input.GetKey (KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                jumpTimeCounter = 0;
            }

            if(grounded)
            {
                jumpTimeCounter = jumpTime;
            }
        }
        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "killbox")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
