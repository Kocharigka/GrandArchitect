using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResizeField : MonoBehaviour
{

    public Slider leftSlider;
    public Slider botomSlider;
    public Text textField;
    public GameObject figure=null;
    public GameObject sliderTip=null;
    public GameObject fieldTip = null;
    public bool active = false;

    void Update()
    {
        if ((botomSlider.value != 1 || leftSlider.value != 1) && sliderTip != null)
        {
            if (!active)
            {
                sliderTip.SetActive(false);
                fieldTip.SetActive(true);
                active = true;
            }

        }
        transform.localScale = new Vector3(botomSlider.value, leftSlider.value, 0);
        transform.localPosition = new Vector3((botomSlider.value - 1) / 2, (leftSlider.value - 1) / 2, 0);
        textField.text = (Mathf.Round((100 * botomSlider.value) * (100 * leftSlider.value))).ToString();
        if (Input.GetKeyDown("space")&&figure!=null)
        {
            figure.GetComponent<SpriteRenderer>().sortingOrder = 4;

        }
        if (Input.GetKeyUp("space") && figure != null)
        {               
                figure.GetComponent<SpriteRenderer>().sortingOrder = -4;         

        }
    }
    


}
