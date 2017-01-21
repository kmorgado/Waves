using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

    KanyeController kanye;

	// Use this for initialization
	void Start () {
        kanye = GameObject.Find("Kanye").GetComponent<KanyeController>();
    }
	
	// Update is called once per frame
	void Update () {
		

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Move Character
            kanye.move(new Vector3(2, 0));
        }
	}
}
