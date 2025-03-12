using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FleetController : MonoBehaviour
{
    public GameObject WeekOne;
    public GameObject WeekTwo;
    public GameObject WeekThree;
    public GameObject WeekFour;

    public Sprite StepOne;
    public Sprite StepTwo;
    public Sprite StepThree;
    public Sprite StepFour;

    Sprite SetIcon;

    float[] array = new float[28];
    int values = 0;

    public void NewValue(float newVal)
    {
        if (values < 28)
        {
            array[values] = newVal;
            getIcon();

            switch (values)
            {
                case 1:
                    WeekOne.transform.GetChild(0).gameObject.SetActive(true);
                    WeekOne.transform.GetChild(0).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 2:
                    WeekOne.transform.GetChild(1).gameObject.SetActive(true);
                    WeekOne.transform.GetChild(1).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 3:
                    WeekOne.transform.GetChild(2).gameObject.SetActive(true);
                    WeekOne.transform.GetChild(2).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 4:
                    WeekOne.transform.GetChild(3).gameObject.SetActive(true);
                    WeekOne.transform.GetChild(3).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 5:
                    WeekOne.transform.GetChild(4).gameObject.SetActive(true);
                    WeekOne.transform.GetChild(4).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 6:
                    WeekOne.transform.GetChild(5).gameObject.SetActive(true);
                    WeekOne.transform.GetChild(5).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 7:
                    WeekOne.transform.GetChild(6).gameObject.SetActive(true);
                    WeekOne.transform.GetChild(6).GetComponent<Image>().sprite = SetIcon;
                    break;

                case 8:
                    WeekTwo.transform.GetChild(0).gameObject.SetActive(true);
                    WeekTwo.transform.GetChild(0).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 9:
                    WeekTwo.transform.GetChild(1).gameObject.SetActive(true);
                    WeekTwo.transform.GetChild(1).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 10:
                    WeekTwo.transform.GetChild(2).gameObject.SetActive(true);
                    WeekTwo.transform.GetChild(2).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 11:
                    WeekTwo.transform.GetChild(3).gameObject.SetActive(true);
                    WeekTwo.transform.GetChild(3).GetComponent<Image>().sprite = SetIcon;
                    break;                    
                case 12:
                    WeekTwo.transform.GetChild(4).gameObject.SetActive(true);
                    WeekTwo.transform.GetChild(4).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 13:
                    WeekTwo.transform.GetChild(5).gameObject.SetActive(true);
                    WeekTwo.transform.GetChild(5).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 14:
                    WeekTwo.transform.GetChild(6).gameObject.SetActive(true);
                    WeekTwo.transform.GetChild(6).GetComponent<Image>().sprite = SetIcon;
                    break;

                case 15:
                    WeekThree.transform.GetChild(0).gameObject.SetActive(true);
                    WeekThree.transform.GetChild(0).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 16:
                    WeekThree.transform.GetChild(1).gameObject.SetActive(true);
                    WeekThree.transform.GetChild(1).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 17:
                    WeekThree.transform.GetChild(2).gameObject.SetActive(true);
                    WeekThree.transform.GetChild(2).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 18:
                    WeekThree.transform.GetChild(3).gameObject.SetActive(true);
                    WeekThree.transform.GetChild(3).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 19:
                    WeekThree.transform.GetChild(4).gameObject.SetActive(true);
                    WeekThree.transform.GetChild(4).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 20:
                    WeekThree.transform.GetChild(5).gameObject.SetActive(true);
                    WeekThree.transform.GetChild(5).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 21:
                    WeekThree.transform.GetChild(6).gameObject.SetActive(true);
                    WeekThree.transform.GetChild(6).GetComponent<Image>().sprite = SetIcon;
                    break;

                case 22:
                    WeekFour.transform.GetChild(0).gameObject.SetActive(true);
                    WeekFour.transform.GetChild(0).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 23:
                    WeekFour.transform.GetChild(1).gameObject.SetActive(true);
                    WeekFour.transform.GetChild(1).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 24:
                    WeekFour.transform.GetChild(2).gameObject.SetActive(true);   
                    WeekFour.transform.GetChild(2).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 25:
                    WeekFour.transform.GetChild(3).gameObject.SetActive(true);
                    WeekFour.transform.GetChild(3).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 26:
                    WeekFour.transform.GetChild(4).gameObject.SetActive(true);
                    WeekFour.transform.GetChild(4).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 27:
                    WeekFour.transform.GetChild(5).gameObject.SetActive(true);
                    WeekFour.transform.GetChild(5).GetComponent<Image>().sprite = SetIcon;
                    break;
                case 28:
                    WeekFour.transform.GetChild(6).gameObject.SetActive(true);
                    WeekFour.transform.GetChild(6).GetComponent<Image>().sprite = SetIcon;
                    break;

            }

            values++;
        }
    }

    void getIcon()
    {
        if (array[values] == 1)
        {
            SetIcon = StepFour;
        }
        else if (array[values] >= 0.66)
        {
            SetIcon = StepThree;
        }
        else if (array[values] >= 0.33)
        {
            SetIcon = StepTwo;
        }
        else if (array[values] > 0)
        {
            SetIcon = StepOne;
        }
    }
}
