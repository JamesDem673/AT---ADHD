using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishedTask : MonoBehaviour
{
    GameObject ToDoBar;
    GameObject PointsTotal;

    private void Start()
    {
        ToDoBar = transform.parent.gameObject;
        PointsTotal = GameObject.FindGameObjectWithTag("Points");
    }

    public void TaskFinished()
    {
        string points = transform.GetChild(4).GetComponent<TMP_InputField>().text;
        int pointsInt = Int32.Parse(points);
        
        string PointsTotalText = PointsTotal.transform.GetChild(0).GetComponent<TMP_Text>().text;
        int pointTotalInt = Int32.Parse(PointsTotalText);

        PointsTotal.transform.GetChild(0).GetComponent<TMP_Text>().SetText((pointsInt + pointTotalInt).ToString());

        Destroy(ToDoBar);
    }
}
