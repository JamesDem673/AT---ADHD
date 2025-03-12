using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HandleTaskFinished : MonoBehaviour
{

    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            float xpos = transform.GetChild(i).position.x;
            float zpos = transform.GetChild(i).position.z;

            transform.GetChild(i).transform.SetPositionAndRotation(new Vector3(xpos, 750 - (i * 90), zpos), Quaternion.identity);
        }
    }
}
