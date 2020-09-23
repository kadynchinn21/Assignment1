﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == null)
        { return; }


        if (other.gameObject.CompareTag("Player"))
        {
            //Don't do anything
        }
        else if(other.gameObject != null)
        {
            //We hit something other than player
            Debug.Log("We hit something: " + other.gameObject.name + "!");
        }
    }
}
