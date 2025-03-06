using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DataStorageScript : MonoBehaviour
{
    public GameObject DateText;
    string date;
    string[] numbers; 

    private void Start()
    {
        date = DateText.GetComponent<TextMeshProUGUI>().text;

        numbers = date.Split('/');

        //foreach (var sub in numbers)
        //{
        //    Debug.Log($"Substring: {sub}");
        //}

    }

    public void IncreaseDate()
    {
        int dayNum = Int32.Parse(numbers[0]);
        int monthNum = Int32.Parse(numbers[1]);
        int maxDays = ReturnMonthLength(monthNum);

        Debug.Log(numbers[0]);

        if (dayNum + 1 > maxDays)
        {
            dayNum = 1;
            monthNum++;

            numbers[0] = dayNum.ToString();
            numbers[1] = monthNum.ToString();
        }
        else if (dayNum + 1 <= maxDays)
        {
            dayNum++;
            numbers[0] = dayNum.ToString();
        }

        DateText.GetComponent<TextMeshProUGUI>().SetText(numbers[0] + "/" + numbers[1] + "/" + numbers[2]);
    }

    private int ReturnMonthLength(int month)
    {
        switch (month)
        {
            case 1:
                return 31;
            case 2:
                return 28;
            case 3:
                return 31;
            case 4:
                return 30;
            case 5:
                return 31;
            case 6:
                return 30;
            case 7:
                return 31;
            case 8:
                return 31;
            case 9:
                return 30;
            case 10:
                return 31;
            case 11:
                return 30;
            case 12:
                return 31;
            default:
                return -1;
                

        }
    }

}


