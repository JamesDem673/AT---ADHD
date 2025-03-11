using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishedTask : MonoBehaviour
{
    GameObject ToDoBar;
    public GameObject PointsTotal;

    private void Start()
    {
        ToDoBar = transform.parent.gameObject;
    }

    public void TaskFinished()
    {
        string points = transform.GetChild(4).GetComponent<TMP_InputField>().text;
        int pointsInt = Int32.Parse(points);
        
        string PointsTotalText = PointsTotal.GetComponent<TMP_Text>().text;
        int pointTotalInt = Int32.Parse(PointsTotalText);

        PointsTotal.GetComponent<TMP_Text>().SetText((pointsInt + pointTotalInt).ToString());

        ToDoBar.SetActive(false);
    }
}
