using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

    KanyeController kanye;
    GenerateTerrain waveTerrain;

	// Use this for initialization
	void Start () {
        kanye = GameObject.Find("Kanye").GetComponent<KanyeController>();
        waveTerrain = GameObject.Find("Wave").GetComponent<GenerateTerrain>();
    }
	
	// Update is called once per frame
	void Update () {
		

        if(Input.GetKeyDown(KeyCode.D))
        {
            kanye.rigidBody2D.mass = 2.5f;
        }
        else
        {
            kanye.rigidBody2D.mass = 1;
        }
	}
}
