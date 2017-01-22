using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

    KanyeController kanye;
    GenerateTerrain waveTerrain;

    public Oxygen oxygen;

	// Use this for initialization
	void Start () {
        kanye = GameObject.Find("Kanye").GetComponent<KanyeController>();
        waveTerrain = GameObject.Find("Wave").GetComponent<GenerateTerrain>();
    }
	
	// Update is called once per frame
	void Update () {

        if (kanye.isInWave)
        {
           // Debug.Log("IN WAVE");

            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("JUMP");

                kanye.body.AddForce(Vector3.up * 100);

                //kanye.transform.localPosition = new Vector3(kanye.transform.localPosition.x, kanye.transform.localPosition.y + .5f, kanye.transform.localPosition.z);
            }

            oxygen.DecreaseOxygen();
        }
        else
        {
            oxygen.IncreaseOxygen();
        }

	}
}
