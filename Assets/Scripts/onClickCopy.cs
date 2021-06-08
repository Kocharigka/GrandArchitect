using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class onClickCopy : MonoBehaviour
{
    public GameObject firstButton;
    public GameObject secondButton;
    private Color clr;
    private void Start()
    {
        clr = GetComponent<Outline>().effectColor;
    }
    public void clickToCopy()
    {
        if (GetComponent<Outline>().effectColor == Color.red)
            GetComponent<Outline>().effectColor = clr;
        else if (firstButton.GetComponent<Outline>().effectColor != Color.red && secondButton.GetComponent<Outline>().effectColor != Color.red)
            GetComponent<Outline>().effectColor = Color.red;
    }

}
