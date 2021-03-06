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
    private bool active = false;

    void Update()
    {
        if ((botomSlider.value != 1 || leftSlider.value != 1) && sliderTip != null&& GameObject.Find("GameManager").GetComponent<GameManager>().getToggle())
        {
            if (!active && GameObject.Find("GameManager").GetComponent<GameManager>().getToggle())
            {
                sliderTip.SetActive(false);
                fieldTip.SetActive(true);
                active = true;
            }

        }
        transform.localScale = new Vector3(botomSlider.value*0.423f, leftSlider.value*0.6f, 0);
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
