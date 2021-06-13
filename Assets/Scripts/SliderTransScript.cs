using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTransScript : MonoBehaviour
{
    private Slider slider;
    public Image fill;
    private Color clr;
    
    // Start is called before the first frame update
    void Update()
    {
        slider = gameObject.GetComponent<Slider>();
        clr = fill.color;
        if (slider.value == 0)
        {
            fill.color = new Color(0, 0, 0, 0);
        }
        else fill.color = clr;
    }

    // Update is called once per frame   
}
