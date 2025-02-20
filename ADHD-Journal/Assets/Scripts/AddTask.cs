using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class AddTask : MonoBehaviour
{
    [SerializeField]
    public Button addTaskButton;
    public GameObject Task;
    public GameObject Content;

    private void Start()
    {
        addTaskButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        GameObject task = GameObject.Instantiate(Task);
        task.transform.SetParent(Content.transform, false);

        Debug.Log(task.gameObject.transform.position);
        task.transform.transform.SetLocalPositionAndRotation(new Vector3(162.5f, (Content.transform.childCount * -60), 0), Quaternion.identity);
        Debug.Log(task.gameObject.transform.position);
    }

}
