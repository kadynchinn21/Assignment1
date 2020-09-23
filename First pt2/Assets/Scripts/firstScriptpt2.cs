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
    void Start()
    {
        Debug.Log("Hello World");

        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
        tankAnim = GetComponent<Animator>();
    }
        public GameObject projectilePrefab;

     

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


        // If the user pushes the space bar then fire a bullet
        // check if user has pushed space
        if(Input.GetKeyDown("space"))
        {
           
            
            // Instantiate the player from a prefab!
           GameObject thisProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
           Rigidbody2D projectileRB = thisProjectile.GetComponent<Rigidbody2D>();
           projectileRB.velocity = new Vector2(0, 12);
           
        }


        // instantiate projectile
        // where? what position does the projectile start in
        // what direction will the projectile move?
        // How fast will the projectile move?
    }
}
