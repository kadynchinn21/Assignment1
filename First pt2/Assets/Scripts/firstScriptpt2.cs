using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScriptpt2 : MonoBehaviour
{
    Rigidbody2D rb2d;
    SpriteRenderer spriteRen;
    Animator tankAnim;

    // declare variables
    // we need a rigidbody refrence
    // we need a sprite renderer reference
    // and we need an animator reference

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Hello World");

        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
        tankAnim = GetComponent<Animator>();

        
	}

    // Update is called once per frame
    void Update()
    {

        // get user input

        // if user pushes up key, then move gameobject up
        // check for key pressed
        // change rigidbody velocity (0, 2)
        // play animation: Player Move 1

        // if user pushes the down key, move gameobject down
        // get user input
        // if user pushes up key, then move gameobject up
        // check for key pressed
        // change rigidbody velocity( 0, -2)
        // play animation: Player Move 1
        // flip sprite on y

        // if user pushes right, move right
        // get user input
        // if user pushes up key, then move gameobject up
        // check for key pressed
        // change rigidbody velocity (2, 0)
        // play animation: PlayerMoveRight

        // if user pushes left, move left
        // get user input
        // if user pushes up key, then move gameobject up
        // check for key pressed
        // change rigidbody velocity (-2, 0)
        // flip sprite on x
        // play animation: PlayerMoveRight

        // Deal with user input
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb2d.velocity = new Vector2(0, 4);
            spriteRen.flipY = false;
            tankAnim.Play("Player Move 1");
        }
        else if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb2d.velocity = new Vector2(0, -4);
            spriteRen.flipY = true;
            tankAnim.Play("Player Move 1");
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(4, 0);
            spriteRen.flipX = false;
            tankAnim.Play("PlayerMoveRight");
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-4, 0);
            spriteRen.flipX = true;
            tankAnim.Play("PlayerMoveRight");
        }
    }
}
