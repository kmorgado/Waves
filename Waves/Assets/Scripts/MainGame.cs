using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

    KanyeController kanye;
    GenerateTerrain waveTerrain;

    public Oxygen oxygen;

    bool StartScreen = true;
    public GameObject StartCanvas;

    public GameObject EndCanvas;
    public GameObject WinCanvas;


    // Use this for initialization
    void Start () {
        kanye = GameObject.Find("Kanye").GetComponent<KanyeController>();
        waveTerrain = GameObject.Find("Wave").GetComponent<GenerateTerrain>();

        Time.timeScale = 0;

        EndCanvas.SetActive(false);
        WinCanvas.SetActive(false);

    }

    // Update is called once per frame
    void Update () {

        if (StartScreen)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCanvas.SetActive(false);
                StartScreen = false;
                Time.timeScale = 1;
            }
        }

        if(oxygen.isDead && kanye.hasWon == false)
        {
            EndCanvas.SetActive(true);

            Time.timeScale = 0;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.LoadLevel(0);
            }

        }

        if(kanye.hasWon)
        {
            WinCanvas.SetActive(true);

            Time.timeScale = 0;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.LoadLevel(0);
            }
        }


        if (kanye.isInWave)
        {
           //Debug.Log("IN WAVE");


            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("JUMP");

                kanye.body.AddForce(Vector3.up * 41);

                //kanye.transform.localPosition = new Vector3(kanye.transform.localPosition.x, kanye.transform.localPosition.y + .5f, kanye.transform.localPosition.z);
            }

            if(kanye.hasWon == false)
                oxygen.DecreaseOxygen();
        }
        else
        {
            oxygen.IncreaseOxygen();
        }

	}
}
