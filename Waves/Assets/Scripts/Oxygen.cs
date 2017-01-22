﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Oxygen : MonoBehaviour
{

    #region Audio

    public AudioClip almostDead;
    public AudioClip dead;

    #endregion

    public GameObject OxygenBar;

    public AudioSource audio1;

    float MaxOxygen = 100;
    float OxygenLevel = 100;


    bool playAlmostDead = true;

    public void AddOxygen(float value)
    {
        OxygenLevel += value;

        if (OxygenLevel >= MaxOxygen)
            OxygenLevel = MaxOxygen;
    }

    public void IncreaseOxygen()
    {
        OxygenLevel += .2f;

        if (OxygenLevel >= MaxOxygen)
            OxygenLevel = MaxOxygen;

        if(OxygenLevel > 80)
        {
            playAlmostDead = true;
            audio1.PlayOneShot(dead);

        }
    }

    public void DecreaseOxygen()
    {
        OxygenLevel -= .2f;

        if (OxygenLevel <= 30)
        {
            if (playAlmostDead)
            { 
            audio1.PlayOneShot(almostDead);
                playAlmostDead = false;
            }
        }

        if (OxygenLevel <= 0)
        {

            OxygenLevel = 0;

            Debug.Log("DEAD");
            //Game over
            if(!audio1.isPlaying)
                audio1.PlayOneShot(dead);

        }
    }

    void Update()
    {

        OxygenBar.transform.localScale = new Vector3(OxygenBar.transform.localScale.x, OxygenLevel / 100.0f, OxygenBar.transform.localScale.z);
    }

}
