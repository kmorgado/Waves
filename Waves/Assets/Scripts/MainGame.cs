using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

    public GameObject kanye;
    public Rigidbody kanyeBody;
    public float jumpUpForce;
    GenerateTerrain waveTerrain;

	// Use this for initialization
	void Start () {
        waveTerrain = GameObject.Find("Wave").GetComponent<GenerateTerrain>();
    }
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Jumping");
            kanyeBody.AddForce(Vector3.up * jumpUpForce);
        }
	}
}
