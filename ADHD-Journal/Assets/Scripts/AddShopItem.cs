using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddShopItem : MonoBehaviour
{
    public float xPos1 = 320f;
    public float xPos2 = 900f;

    bool lineOne = true;

    public GameObject ShopItem;
    public GameObject Content;
    int line = 1;

    public void AddItem()
    {
        GameObject shop = GameObject.Instantiate(ShopItem);
        shop.transform.SetParent(Content.transform, false);

        if (lineOne)
        {
            shop.transform.transform.SetLocalPositionAndRotation(new Vector3(xPos1, (line * -75) -65, 0), Quaternion.identity);
            lineOne = false;
        }
        else if (!lineOne)
        {
            shop.transform.transform.SetLocalPositionAndRotation(new Vector3(xPos2, (line * -75) - 65, 0), Quaternion.identity);
            lineOne = true;
            line++;
        }
    }

}
