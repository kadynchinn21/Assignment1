using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    // Create public variables(GameObjects)
    public GameObject player;
    public GameObject mainMenu;
    public GameObject curser;
    public GameObject Level01;
    public GameObject[] curserPositions;
    public GameObject playerSelectIndicator;
    public Text thisText;

    public Camera gameCamera;
    public Camera mainCamera;

    private bool onStartGameSelection;
    // Start is called before the first frame update
    void Start()
    {
        onStartGameSelection = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        // Check for space or enter key pressed
        // if pressed then deactivate the menu game object
        // and show the player character game object
        //if (Input.GetKey("space") || Input.GetKey("return"))
        //{
        //    player.SetActive(true);
        //    mainMenu.SetActive(false);
        //}

        // if the user presses up
        // move curser to next selection

        if(Input.GetKeyDown("up")|| Input.GetKeyDown("down"))
        {
            if(onStartGameSelection)
            {
                onStartGameSelection = false;
                thisText = playerSelectIndicator.GetComponent<Text>();
            }
            else
            {
                 onStartGameSelection = true;
            }
           
        }

        if (onStartGameSelection)
        {
            curser.transform.position = curserPositions[1].transform.position;
        }
        else
        {
            curser.transform.position = curserPositions[0].transform.position;
        }
        
        if(onStartGameSelection &&  Input.GetKeyDown("return"))
        {
            Level01.SetActive(true);
            player.SetActive(true);
            mainMenu.SetActive(false);

            mainCamera.enabled = false;
            gameCamera.enabled = true;
        }


    
        if (onStartGameSelection && Input.GetKeyDown("return"))
        {
            // toggle number of players
        }

        // if user presses down
        // move curser to next selection

        // if the user presses enter AND if onStartGameSelection is true then
        // toggle the players

        // if the user presses enter AND if onStartGameSelection is on then
        // start the game
    }
}