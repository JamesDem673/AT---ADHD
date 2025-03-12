using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabControllerScript : MonoBehaviour
{
    public GameObject ToDoList;
    public GameObject DailyTasks;
    public GameObject Shop;
    public GameObject Fleet;

    public void ShowToDoList()
    {
        ToDoList.SetActive(true);
        DailyTasks.SetActive(false);
        Shop.SetActive(false);
        Fleet.SetActive(false);
    }

    public void ShowShop() 
    {
        ToDoList.SetActive(false);
        DailyTasks.SetActive(false);
        Shop.SetActive(true);
        Fleet.SetActive(false);
    }

    public void ShowDailyTasks() 
    {
        ToDoList.SetActive(false);
        DailyTasks.SetActive(true);
        Shop.SetActive(false);
        Fleet.SetActive(false);
    }

    public void ShowFleet()
    {
        ToDoList.SetActive(false);
        DailyTasks.SetActive(false);
        Shop.SetActive(false);
        Fleet.SetActive(true);
    }
}
