using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NextDay : MonoBehaviour
{
    [SerializeField]
    public GameObject Content;
    public Button addTaskButton;
    public TMP_Text pointSumText;
    int pointSumInt = 0;
    public GameObject DataStorage;
    public GameObject FleetControllerRef;
    
    private void Start()
    {
        addTaskButton.onClick.AddListener(SetNextDay);
    }

    public void SetNextDay()
    {
        int ticked = 0;

        for (int i = 0; i < Content.transform.childCount; i++)
        {
            GameObject taskRow = Content.transform.GetChild(i).gameObject;
            GameObject buttonUI = taskRow.transform.GetChild(0).gameObject;

            if (buttonUI.GetComponent<Toggle>().isOn == true)
            {
                ticked++;
                GameObject points = buttonUI.transform.GetChild(2).gameObject;
                String pointsStr = (points.GetComponent<InputValue>().ReturnPointValue()).ToString();
                int pointsInt = int.Parse(pointsStr);
                pointSumInt += pointsInt;
            }
      
            pointSumText.SetText(pointSumInt.ToString());
        }

        float decimalTicked = (float)ticked / (float)Content.transform.childCount;

        FleetControllerRef.GetComponent<FleetController>().NewValue(decimalTicked);

        DataStorage.GetComponent<DataStorageScript>().IncreaseDate();
    }
}
