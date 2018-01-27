﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravityBehaviour : MonoBehaviour {

    public float gravityMod; //gravityMod 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col) //Si le joueur touche le bonus
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Rigidbody>().mass *= gravityMod;
        }
    }
}
