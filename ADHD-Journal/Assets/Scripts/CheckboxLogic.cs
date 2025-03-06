using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckboxLogic : MonoBehaviour
{
    GameObject Tracker;
    public Toggle checkboxToggle;

    private void Start()
    {
        var temp = GameObject.Find("ProgressBoat");
        Tracker = temp.gameObject;
    }

    public void OnToggleChanged(bool state)
    {

        if (state == true)
        {
            OnChecked();
        }
        else
        {
            OnUnchecked();
        }
    }

    // Start is called before the first frame update
    void OnChecked()
    {
        Tracker.GetComponent<ImageController>().IncreaseCompleted();
    }

    // Update is called once per frame
    void OnUnchecked()
    {
        Tracker.GetComponent<ImageController>().DecreaseCompleted();
    }    
}
