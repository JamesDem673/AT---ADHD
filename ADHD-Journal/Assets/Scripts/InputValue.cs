using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputValue : MonoBehaviour
{
    public GameObject GO;
    int points = 50;

    public void valChanged()
    {
        string s_points = GO.GetComponent<TMP_InputField>().text;
        points = Int32.Parse(s_points);
    }

    public int ReturnPointValue()
    { 
        return points;
    }
}
