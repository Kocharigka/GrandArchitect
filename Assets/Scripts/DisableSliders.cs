using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableSliders : MonoBehaviour
{
    public Slider LeftSilder;
    public Slider BottomSlider;
    public void Disable()
    {
        LeftSilder.interactable = false;
        BottomSlider.interactable = false;
    }


}
