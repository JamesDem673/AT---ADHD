using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameValue : MonoBehaviour
{
    public GameObject GO;
    String strName = "";

    public void valChanged()
    {
        strName = GO.GetComponent<TMP_InputField>().text;
    }

    public string ReturnName()
    {
        return strName;
    }
}
