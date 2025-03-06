using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressTracker : MonoBehaviour
{
    public GameObject TaskList;
    public Image progressImage;
    public Sprite icon1;
    public Sprite icon2;
    public Sprite icon3;
    public Sprite icon4;

    public void Update()
    {   
        int totalTicks = TaskList.transform.childCount;
        int ticked = 0;

        for (int i = 0; i < TaskList.transform.childCount; i++)
        {
            GameObject taskRow = TaskList.transform.GetChild(i).gameObject;
            GameObject buttonUI = taskRow.transform.GetChild(0).gameObject;

            if (buttonUI.GetComponent<Toggle>().isOn)
            {
                ticked++;
            }
        }

        float decimalTicked = (float)ticked / (float)totalTicks;

        if (decimalTicked == 1)
        {
            progressImage.sprite = icon4;
        }
        else if (decimalTicked >= 0.66)
        {
            progressImage.sprite = icon3;
        }
        else if (decimalTicked >= 0.33)
        {
            progressImage.sprite = icon2;
        }
        else if (decimalTicked > 0)
        {
            progressImage.sprite = icon1;
        }

    }
}

