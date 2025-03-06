using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DataStorageScript : MonoBehaviour
{
    public GameObject DateText;
    public GameObject TaskList;
    string date;
    string[] numbers; 
    List<SaveSlot> SaveDataList = new List<SaveSlot>();
    public GameObject AddTask;

    private void Start()
    {
        date = DateText.GetComponent<TextMeshProUGUI>().text;

        numbers = date.Split('/');

        //foreach (var sub in numbers)
        //{
        //    Debug.Log($"Substring: {sub}");
        //}

    }
    public void SaveData()
    {
        List<TaskSlot> DailyTasks = new List<TaskSlot>();

        for (int i = 0; i < TaskList.transform.childCount; i++)
        {
            GameObject taskRow = TaskList.transform.GetChild(i).gameObject;
            GameObject buttonUI = taskRow.transform.GetChild(0).gameObject;

            GameObject name = buttonUI.transform.GetChild(1).gameObject;
            String nameStr = name.GetComponent<NameValue>().ReturnName();

            GameObject points = buttonUI.transform.GetChild(2).gameObject;
            String pointsStr = (points.GetComponent<InputValue>().ReturnPointValue()).ToString();
            int pointsInt = int.Parse(pointsStr);

            bool completed = buttonUI.GetComponent<UnityEngine.UI.Toggle>().isOn;

            TaskSlot newSlot = new TaskSlot(nameStr, completed, pointsInt);
            DailyTasks.Add(newSlot);
        }

        SaveSlot DailySave = new SaveSlot(date, DailyTasks);



        bool foundSave = false;

        for (int i = 0; i < SaveDataList.Count; i++)
        {
            if (SaveDataList[i].Name == date)
            {
                Debug.Log("Found");
                SaveDataList[i] = DailySave;
                foundSave = true;
                break;
            }    
        }

        if (!foundSave)
        {
            SaveDataList.Add(DailySave);
        }
    }
    public void LoadData()
    {
        bool DataFound = false;
        int dataIndex = -1;

        for (int i = 0; i < SaveDataList.Count; i++)
        {
            if (SaveDataList[i].Name == date)
            {
                DataFound = true;
                Debug.Log(SaveDataList[i].Name + " == " + date);
                dataIndex = i;
                break;
            }
        }

        if (DataFound)
        {
            if (SaveDataList[dataIndex].Slots.Count < TaskList.transform.childCount)
            {
                int tasksToRemove = TaskList.transform.childCount - SaveDataList[dataIndex].Slots.Count;

                for (int i = 0; i < tasksToRemove; i++)
                {
                    GameObject toDelete = TaskList.transform.GetChild(TaskList.transform.childCount - 1).gameObject;

                    toDelete.transform.SetParent(null, false);
                    Destroy(toDelete);
                }
            }
            else if (TaskList.transform.childCount < SaveDataList[dataIndex].Slots.Count)
            {
                int tasksToAdd = SaveDataList[dataIndex].Slots.Count - TaskList.transform.childCount;

                for (int i = 0; i < tasksToAdd; i++)
                {
                    AddTask.GetComponent<AddTask>().TaskOnClick();
                }
            }

            for (int i = 0; i < TaskList.transform.childCount; i++)
            {
                GameObject taskRow = TaskList.transform.GetChild(i).gameObject;
                GameObject buttonUI = taskRow.transform.GetChild(0).gameObject;

                bool setBool = SaveDataList[dataIndex].Slots[i].Completed;
                buttonUI.GetComponent<UnityEngine.UI.Toggle>().isOn = setBool;

                GameObject nameUI = buttonUI.transform.GetChild(1).gameObject;
                nameUI.GetComponent<NameValue>().setString(SaveDataList[dataIndex].Slots[i].Name);

                GameObject pointsUI = buttonUI.transform.GetChild(2).gameObject;
                pointsUI.GetComponent<InputValue>().setPoints(SaveDataList[dataIndex].Slots[i].Points.ToString());
            }
        }
        else if (!DataFound)
        {
            for (int i = 0; i < TaskList.transform.childCount; i++)
            {
                GameObject taskRow = TaskList.transform.GetChild(i).gameObject;
                GameObject buttonUI = taskRow.transform.GetChild(0).gameObject;

                buttonUI.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
            }
        }
    }
    public void IncreaseDate()
    {
        SaveData();

        int dayNum = Int32.Parse(numbers[0]);
        int monthNum = Int32.Parse(numbers[1]);
        int yearNum = Int32.Parse(numbers[2]);

        int maxDays = ReturnMonthLength(monthNum);

        if (dayNum + 1 > maxDays)
        {
            dayNum = 1;


            if (monthNum == 12)
            {
                yearNum++;
                monthNum = 1;
            }
            else
            {
                monthNum++;
            }

            numbers[0] = dayNum.ToString();
            numbers[1] = monthNum.ToString();
            numbers[2] = yearNum.ToString();
        }
        else if (dayNum + 1 <= maxDays)
        {
            dayNum++;
            numbers[0] = dayNum.ToString();
        }

        date = numbers[0] + "/" + numbers[1] + "/" + numbers[2];
        DateText.GetComponent<TextMeshProUGUI>().SetText(numbers[0] + "/" + numbers[1] + "/" + numbers[2]);

        LoadData();
    }
    public void DecreaseDate()
    {
        SaveData();

        int dayNum = Int32.Parse(numbers[0]);
        int monthNum = Int32.Parse(numbers[1]);
        int yearNum = Int32.Parse(numbers[2]);

        int maxDays = ReturnMonthLength(monthNum);

        if (dayNum == 1)
        {
            if (monthNum == 1)
            {
                monthNum = 12;
                yearNum--;
            }
            else
            {
                monthNum--;
            }
            
            dayNum = ReturnMonthLength(monthNum);

            numbers[0] = dayNum.ToString();
            numbers[1] = monthNum.ToString();
            numbers[2] = yearNum.ToString();
        }
        else
        {
            dayNum--;
            numbers[0] = dayNum.ToString();
        }

        date = numbers[0] + "/" + numbers[1] + "/" + numbers[2];
        DateText.GetComponent<TextMeshProUGUI>().SetText(numbers[0] + "/" + numbers[1] + "/" + numbers[2]);

        LoadData();
    }
    private int ReturnMonthLength(int month)
    {
        switch (month)
        {
            case 1:
                return 31;
            case 2:
                if (DateTime.IsLeapYear(Int32.Parse(numbers[2])))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
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

struct SaveSlot
{
    public string Name;
    public List<TaskSlot> Slots;

    public SaveSlot(string name, List<TaskSlot> slots)
    {
        this.Name = name;
        this.Slots = slots; 
    }
    
}

struct TaskSlot
{
    public string Name;
    public bool Completed;
    public int Points;

    public TaskSlot(string name, bool completed, int points)
    {
        this.Name = name;
        this.Completed = completed;
        this.Points = points; 
    }
}