using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToDo : MonoBehaviour
{
    [SerializeField]
    public Button addTaskButton;
    public GameObject Task;
    public GameObject Content;
    RectTransform rt;
    int currentHeight = 75;
    private void Start()
    {
        addTaskButton.onClick.AddListener(TaskOnClick);
        rt = Content.GetComponent<RectTransform>();
    }
    public void TaskOnClick()
    {
        rt.sizeDelta = new Vector2(0, currentHeight - 50);

        GameObject task = GameObject.Instantiate(Task);
        task.transform.SetParent(Content.transform, false);
        task.transform.transform.SetLocalPositionAndRotation(new Vector3(500, (Content.transform.childCount * -50), 0), Quaternion.identity);

        currentHeight += 50;
        rt.sizeDelta = new Vector2(0, currentHeight + 50);
    }

}
