using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResizeField : MonoBehaviour
{

    public Slider leftSlider;
    public Slider botomSlider;
    public Text textField;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(botomSlider.value, leftSlider.value, 0);
        transform.localPosition = new Vector3((botomSlider.value - 1) / 2, (leftSlider.value - 1) / 2, 0);
        textField.text = (Mathf.Round((100 * botomSlider.value) * (100 * leftSlider.value))).ToString();
    }
}
