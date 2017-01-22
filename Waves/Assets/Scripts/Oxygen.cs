using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

   public class Oxygen : MonoBehaviour
    {

        public GameObject OxygenBar;

        float MaxOxygen = 100;
        float OxygenLevel = 100;


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
    }

    public void DecreaseOxygen()
        {
            OxygenLevel -= .2f;

            if (OxygenLevel <= 0)
            {
                //Game over
                OxygenLevel = 0;
            }
        }

        void Update()
        {
            OxygenBar.transform.localScale = new Vector3(OxygenBar.transform.localScale.x, OxygenLevel / 100.0f, OxygenBar.transform.localScale.z);
        }

    }
