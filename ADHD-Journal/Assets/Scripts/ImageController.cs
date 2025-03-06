using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public Image progressTracker;

    public Sprite StepOne;
    public Sprite StepTwo;
    public Sprite StepThree;
    public Sprite StepFour;

    public GameObject TaskList;

    float completed;
    float maxTasks;

    private void Start()
    {
        maxTasks = TaskList.transform.childCount;
    }

    public void IncreaseMaxTasks()
    {
        maxTasks++;
    }

    public void IncreaseCompleted()
    {
        completed++;
        UpdateIcon();
    }

    public void DecreaseCompleted()
    {
        completed--;
        UpdateIcon();

        if (completed == 0)
        {
            progressTracker.enabled = false;
        }
    }

    private void UpdateIcon()
    {
        if (completed / maxTasks > 0 && completed / maxTasks <= 0.25)
        {
            progressTracker.enabled = true;
            progressTracker.sprite = StepOne;
        }
        else if (completed / maxTasks > 0.25 && completed / maxTasks <= 0.50)
        {
            progressTracker.enabled = true;
            progressTracker.sprite = StepTwo;

        }
        else if (completed / maxTasks > 0.50 && completed / maxTasks <= 0.75)
        {
            progressTracker.enabled = true;
            progressTracker.sprite = StepThree;
 
        }
        else if (completed / maxTasks > 0.75 && completed / maxTasks <= 1.0)
        {
            progressTracker.enabled = true;
            progressTracker.sprite = StepFour;    
        }

    }

}
