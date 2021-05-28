using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountAnswer : MonoBehaviour
{
    public Text nText;
    public Text kText;
    public Text sText;
    public Text nTextFormula;
    public Text kTextFormula;
    public Text sTextFormula;
    public Text answerField;
    public Button checkButton;

    // Start is called before the first frame update
    public void GetAnswer()
    {        
        if (nText.text == nTextFormula.text && kText.text == kTextFormula.text && sText.text == sTextFormula.text&&nTextFormula.text!="0")
        {
           
            float answer = float.Parse(kTextFormula.text) / float.Parse(nTextFormula.text) * float.Parse(sTextFormula.text);
           
            int len = 6-answer.ToString().Length;
            string l = "";
            if (len > 0)
            {
                l = new string(' ', len);
            }            
            answerField.text= "�����:"+Mathf.Round(answer)+l+"��2";
            checkButton.interactable = true;           
        }
        else
        {
            answerField.text = "�����:______��2";
            checkButton.interactable = false;
        }

    }
    private void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            nTextFormula.text = nText.text;
            kTextFormula.text = kText.text;
            sTextFormula.text = sText.text;
            GetAnswer();
        }
    }
}
