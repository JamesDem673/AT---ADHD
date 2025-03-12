using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ReducePoints : MonoBehaviour
{
    GameObject PointValue;
    TMPro.TMP_Text m_Text;

    private void Start()
    {
        PointValue = GameObject.FindGameObjectWithTag("Points").transform.GetChild(0).gameObject; 
    }

    public void Reduce()
    {
        m_Text = PointValue.GetComponent<TMPro.TMP_Text>();

        int points = Int32.Parse(m_Text.text);

        int pointsCost = Int32.Parse(transform.parent.GetChild(2).GetComponent<TMP_InputField>().text);
        
        if (pointsCost < points)
        {
           points = points - pointsCost;
           PointValue.GetComponent<TMPro.TMP_Text>().SetText(points.ToString());
        }
    }
}
