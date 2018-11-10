using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ConvMillPowerEst : MonoBehaviour {

    public float length = 6;
    public float diameter = 5;
    public InputField millSpeed;
    public InputField chargeFill;
    public InputField ballFill;
    public InputField interSF;
    public InputField liftAngle;
    public InputField losses;
    public InputField millSol;
    public InputField oreDens;
    public InputField ballDens;
    public Text results;

    void Start()
    {
        length = length * 3.2808f;
        diameter = diameter * 3.2808f;
    }
    // Use this for initialization
    public void calculate ()
    {
        double rpmcritspeed = (76.6 / Mathf.Sqrt(diameter)) * (Single.Parse(millSpeed.text)/100);
        results.text = "RPM: " + rpmcritspeed.ToString();
        Debug.Log(rpmcritspeed);
    }
}
