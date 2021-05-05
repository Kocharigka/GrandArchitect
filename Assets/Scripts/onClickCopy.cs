using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class onClickCopy : MonoBehaviour
{
    public GameObject firstButton;
    public GameObject secondButton;
    public void clickToCopy()
    {
        if(firstButton.GetComponent<Outline>().effectColor != Color.red && secondButton.GetComponent<Outline>().effectColor != Color.red)
            GetComponent<Outline>().effectColor = Color.red;
    }

}
